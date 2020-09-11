using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("Person", Schema = "Person")]
      
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        public string PersonType { get; set; }

        public bool NameStyle { get; set; }

        public string Title { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public string Suffix { get; set; }

        public int EmailPromotion { get; set; }

        public  string AdditionalContactInfo { get; set; }

        public string Demographics { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
