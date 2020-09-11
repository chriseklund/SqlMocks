﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("Department", Schema = "HumanResources")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short DepartmentID { get; set; }

        public string Name { get; set; }

        public string GroupName { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
