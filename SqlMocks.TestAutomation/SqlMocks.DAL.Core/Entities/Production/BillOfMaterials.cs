using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.Entities
{
    [Table("BillOfMaterials", Schema = "Production")]
    public class BillOfMaterials
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillOfMaterialsID { get; set; }

        public int? ProductAssemblyID { get; set; }

        public int ComponentID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string UnitMeasureCode { get; set; }

        public short BOMLevel { get; set; }

        public decimal PerAssemblyQty { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
