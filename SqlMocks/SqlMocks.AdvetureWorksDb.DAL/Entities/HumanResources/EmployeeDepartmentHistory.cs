using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("EmployeeDepartmentHistory",Schema="HumanResources")]
    public class EmployeeDepartmentHistory
    {
        [Key]
        public int BusinessEntityID { get; set; }

        [Key]
        public short DepartmentID { get; set; }

        [Key]
        public byte ShiftID { get; set; }

        [Key]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
