
using Cars.Models;//package name//change it
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers

{
    public interface IStoreRepo
    {
        List<Store> GetAll();
        Store Get(int id);
        int Insert(Store c);
        int Delete(Store c);
        int Update(Store c);
    }
}
