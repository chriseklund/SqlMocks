﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("EmployeeDepartmentHistory",Schema="HumanResources")]
    public class EmployeeDepartmentHistory
    {
        public int BusinessEntityID { get; set; }

        public short DepartmentID { get; set; }

        public byte ShiftID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
