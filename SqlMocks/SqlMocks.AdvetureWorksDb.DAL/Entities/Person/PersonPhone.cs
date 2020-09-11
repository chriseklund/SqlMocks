using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("PersonPhone", Schema = "Person")]
      
    public class PersonPhone
    {
        public int BusinessEntityID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
