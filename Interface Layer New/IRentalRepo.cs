
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public interface IRentalRepo : IRepository<Rental>, ISearch<Rental>
    {

    }
}
