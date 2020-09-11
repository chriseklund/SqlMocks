using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("Password", Schema = "Person")]
    public class Password
    {
        public int BusinessEntityID { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
