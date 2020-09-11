using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("Shift", Schema = "HumanResources")]
    public class Shift
    {
        public byte ShiftID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
