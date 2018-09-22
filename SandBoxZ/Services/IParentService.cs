using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Services
{
    public interface IParentService
    {
        void AddChild(Child  child);
        void UpdateAccount();
        IEnumerable<History> GetHistories();
         
    }
}
