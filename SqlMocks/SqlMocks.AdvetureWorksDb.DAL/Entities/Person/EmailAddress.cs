using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("EmailAddress", Schema = "Person")]
    public class Email
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        public int EmailAddressID { get; set; }

        public string EmailAddress { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
