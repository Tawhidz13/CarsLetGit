
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public interface IRentalRepo
    {
        List<Rental> GetAll();
        Rental Get(int id);
        int Insert(Rental c);
        int Delete(Rental c);
        int Update(Rental c);
    }
}
