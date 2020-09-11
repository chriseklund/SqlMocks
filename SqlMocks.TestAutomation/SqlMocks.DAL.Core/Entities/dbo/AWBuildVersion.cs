using System;

namespace SqlMocks.DAL.Core
{
    public class AWBuildVersion
    {
        public byte SystemInformationID { get; set; }

        public string Database_Version { get; set; }

        public DateTime VersionDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
