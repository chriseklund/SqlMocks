using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("CountryRegion", Schema = "Person")]
    public class CountryRegion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CountryRegionCode { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
