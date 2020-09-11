using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SqlMocks.DAL.Core.Entities
{
    [Table("StateProvince", Schema = "Person")]
      
    public class StateProvince
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateProvinceID { get; set; }

        public string StateProvinceCode { get; set; }

        public string CountryRegionCode { get; set; }

        public bool IsOnlyStateProvinceFlag { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int TerritoryID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
