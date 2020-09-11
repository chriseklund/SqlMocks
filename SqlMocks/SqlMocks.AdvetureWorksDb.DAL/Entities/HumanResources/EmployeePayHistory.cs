using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("EmployeePayHistory", Schema = "HumanResources")]
    public class EmployeePayHistory
    {
        [Key]
        public int BusinessEntityID { get; set; }

        [Key]
        public DateTime RateChangeDate { get; set; }

        public decimal Rate { get; set; }

        public byte PayFrequency { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
