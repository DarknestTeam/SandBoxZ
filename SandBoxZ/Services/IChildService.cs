using SandBoxZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Services
{
  public  interface IChildService
    {
        IEnumerable<History> GetHistories();
        IEnumerable<Quest> GetQuests(int id);
        void Payment(int cardId);
        void AddAmount(int id);
    }
}
