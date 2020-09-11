using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("Employee", Schema = "HumanResources")]
    public class Employee
    {
        public int BusinessEntityID { get; set; }

        public string NationalIDNumber { get; set; }

        public string LoginID { get; set; }

        public short? OrganizationLevel { get; set; }

        public string JobTitle { get; set; }

        public DateTime BirthDate { get; set; }

        public string MaritalStatus { get; set; }

        public string Gender { get; set; }

        public DateTime HireDate { get; set; }

        public bool SalariedFlag { get; set; }

        public short VacationHours { get; set; }

        public short SickLeaveHours { get; set; }

        public bool CurrentFlag { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
