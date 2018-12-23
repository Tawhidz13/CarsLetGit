
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public interface CarData
    {
        List<CarData> GetAll();
        CarData Get(int id);
        int Insert(CarData c);
        int Delete(CarData c);
        int Update(CarData c);
    }
}
