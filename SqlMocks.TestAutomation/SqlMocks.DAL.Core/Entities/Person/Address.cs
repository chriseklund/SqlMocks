using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace SqlMocks.DAL.Core.Entities
{
    [Table("Address", Schema = "Person")]
    public class Address
    {
        public int AddressID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public int StateProvinceID { get; set; }

        public string PostalCode { get; set; }

        public string SpatialLocation { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
