using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SqlMocks.DAL.Core.Entities
{
    public class DatabaseLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DatabaseLogID { get; set; }

        public DateTime PostTime { get; set; }

        public string DatabaseUser { get; set; }

        public string Event { get; set; }

        public string Schema { get; set; }

        public string Object { get; set; }

        public string TSQL { get; set; }

        public string XmlEvent { get; set; }

    }
}
