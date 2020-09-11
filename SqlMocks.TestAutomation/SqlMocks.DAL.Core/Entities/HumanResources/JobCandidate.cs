using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("JobCandidate", Schema = "HumanResources")]
    public class JobCandidate
    {
        public int JobCandidateID { get; set; }

        public int? BusinessEntityID { get; set; }

        public string Resume { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
