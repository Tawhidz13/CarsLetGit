
using Cars.Models;//package name//change it
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers

{
    
    public interface IStoreRepo : IRepository<Store>, ISearch<Store>
    {

    }
}

