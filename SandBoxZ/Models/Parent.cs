using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Models
{
    public class Parent
    {
        // binnd 
        public int Id { get; set; }
        public int IdMBank { get; set; }
        public float Bill { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public float SumRefill { get; set; }
        public IEnumerable<Child> Childs { get; set; }
    }
}
