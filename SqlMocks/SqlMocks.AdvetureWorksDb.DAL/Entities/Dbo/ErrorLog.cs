using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SqlMocks.DAL.Core.Entities
{
    public class ErrorLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorLogID { get; set; }

        public DateTime ErrorTime { get; set; }

        public string UserName { get; set; }

        public int ErrorNumber { get; set; }

        public int? ErrorSeverity { get; set; }

        public int? ErrorState { get; set; }

        public string ErrorProcedure { get; set; }

        public int? ErrorLine { get; set; }

        public string ErrorMessage { get; set; }

    }
}
