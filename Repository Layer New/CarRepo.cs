
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class CarRepo : Repository<Car>, ICarRepo
    {
        public CarRepo(SampleDBContext context)
            : base(context)
        { }

        public List<Car> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
