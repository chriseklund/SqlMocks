using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("BusinessEntityAddress", Schema = "Person")]
    public class BusinessEntityAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        public int AddressID { get; set; }

        public int AddressTypeID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
