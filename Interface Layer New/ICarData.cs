
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Models;

namespace Cars.Controllers
{
    public interface ICarData : IRepository<CarData>, ISearch<CarData>
    {

    }
}
