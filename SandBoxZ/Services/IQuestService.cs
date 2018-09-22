using SandBoxZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Services
{
    public interface IQuestService
    {
        Quest GetQuest(int id);
    }
}
