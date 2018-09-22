using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Models
{
    public class History
    {
        public int StatisticsId { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public int DepositId { get; set; }
        public float Amount { get; set; }
        public DateTime DateOfDeposit { get; set; }
    }
}
