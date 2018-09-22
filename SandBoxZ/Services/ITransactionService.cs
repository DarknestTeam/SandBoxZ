using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxZ.Services
{
    public interface ITransactionService<T> where T:class
    { 
        void Tranfer(T post ,T receiv);
    }
}
