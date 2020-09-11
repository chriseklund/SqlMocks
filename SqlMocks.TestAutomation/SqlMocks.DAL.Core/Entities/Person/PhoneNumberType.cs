using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("PhoneNumberType", Schema = "Person")]
      
    public class PhoneNumberType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneNumberTypeID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
