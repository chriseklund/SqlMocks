using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("BusinessEntity", Schema = "Person")]
    public class BusinessEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
