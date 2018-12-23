
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public interface IcarRepo

    {
        List<Car> GetAll();
        Car Get(int id);
        int Insert(Car c);
        int Delete(Car c);
        int Update(Car c);
    }
}
