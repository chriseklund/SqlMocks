using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("BusinessEntityContact", Schema = "Person")]
    public class BusinessEntityContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        public int PersonID { get; set; }

        public int ContactTypeID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
