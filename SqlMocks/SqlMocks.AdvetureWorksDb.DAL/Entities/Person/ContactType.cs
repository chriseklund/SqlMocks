using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("ContactType", Schema = "Person")]
    public class ContactType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactTypeID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
