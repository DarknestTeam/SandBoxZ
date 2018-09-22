using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Models
{
    public class Child
    {
        public int ChildId { get; set; }
        public History histories { get; set; }
        public int HistoryId { get; set; }
        public int BillId { get; set; }
        public float ChildBill { get; set; }
        public Bonus bonuses { get; set; }
    }
}
