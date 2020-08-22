using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlMocks
{
    public interface IMock<Mock> : IDisposable
    {
        public void Dispose();
        public void MockObject(string schema, string objectName);
        public int ExecuteNonQuery(string cmdText);
        public DataTable ExecuteQueryToDatatable(string cmdText);
        public void MockStoredProcedureToReturnData(DataTable dataTable, string schema, string storedProcedure, int numberOfInputParams);

    }
    public class Mock : IMock<Mock>
    {
        private SqlConnection cn;
        private SqlTransaction tran;
        private string sessionId;
        private bool disposedValue;

        public SqlConnection SqlCn { get => cn; set => value = cn; }
        public SqlTransaction SqlTran { get => tran; set => value = tran; }

        public string SessionId { get => sessionId; set => value = sessionId; }

        public Mock(string cnString)
        {
            sessionId = Guid.NewGuid().ToString().Replace("-", "");
            cn = new SqlConnection(cnString);
            cn.Open();
            tran = cn.BeginTransaction(sessionId);
        }

        /// <summary>
        ///     Can be used to mock Table, View, and Table Constraint Objects.
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="cn"></param>
        /// <param name="schema"></param>
        /// <param name="objectName"></param>
        /// <param name="sessionId"></param>
        public void MockObject(string schema, string objectName)
        {
            using (var cmd = cn.CreateCommand())
            {
                cmd.Transaction = tran;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"EXEC sp_rename '{schema}.{objectName}', '{objectName}_{sessionId}'";

                _ = cmd.ExecuteNonQuery();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT TOP(0) * INTO {schema}.{objectName} FROM dbo.{objectName}_{sessionId}";
                _ = cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Create mock stored procedure that will return expected dataset for functionality under test to call. 
        /// Limitations: When calling mocked stored procedure, calling code cannot explicitly name the actual params it is passing to since these mocked params
        /// </summary>
        /// <param name="dataTable">DataTable with actual values expected to be returned when mock proc is called.</param>
        /// <param name="schema"></param>
        /// <param name="storedProcedure"></param>
        /// <param name="numberOfInputParams">These will be mocked parameters with mocked names</param>
        public void MockStoredProcedureToReturnData(DataTable dataTable, string schema, string storedProcedure, int numberOfInputParams)
        {
            using (var cmd = cn.CreateCommand())
            {
                cmd.Transaction = tran;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"EXEC sp_rename '{schema}.{storedProcedure}', '{storedProcedure}_{sessionId}'";

                _ = cmd.ExecuteNonQuery();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * INTO {schema}.tempMockSp_{sessionId} FROM {dataTable}";
                _ = cmd.ExecuteNonQuery();

                cmd.CommandType = CommandType.Text;
                string commandText = $"Create Procedure {schema}.{storedProcedure}{Environment.NewLine}";

                for (var i = 1; i < numberOfInputParams; i++)
                {
                    commandText += $"@inputParm{i} varchar(Max),";
                }

                commandText = commandText.Substring(0, commandText.Length - 1);
                commandText += $"{Environment.NewLine} AS {Environment.NewLine} BEGIN {Environment.NewLine} SELECT * FROM {schema}.tempMockSp_{sessionId}{Environment.NewLine}END";

                cmd.CommandText = commandText;

                _ = cmd.ExecuteNonQuery();
            }
            
        }

        public int ExecuteNonQuery(string cmdText)
        {
            using (var cmd = cn.CreateCommand())
            { 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;

                return cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// This will allow you to pass in sql query as command text and get data table in response to iterate over for Assert Tests.
        /// </summary>
        /// <param name="cmdText">String sql text to return result set to table.</param>
        /// <returns></returns>
        public DataTable ExecuteQueryToDatatable(string cmdText)
        {
            using (var cmd = cn.CreateCommand())
            {
                var result = new DataTable();
                cmd.Transaction = tran;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;

                var reader = cmd.ExecuteReader();
                result.BeginLoadData();
                result.Load(reader);
                result.EndLoadData();
                return result;
            }
        }
        /// <summary>
        /// handles disposal of mock objects
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    tran.Rollback();
                    tran.Dispose();
                    cn.Close();
                    cn.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Mock()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
               
    }
}
