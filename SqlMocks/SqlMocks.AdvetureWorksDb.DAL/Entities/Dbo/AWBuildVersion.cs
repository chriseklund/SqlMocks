using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core
{
    public class AWBuildVersion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte SystemInformationID { get; set; }

        public string Database_Version { get; set; }

        public DateTime VersionDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
