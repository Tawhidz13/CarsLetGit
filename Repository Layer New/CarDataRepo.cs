

using Cars.Controllers;
using Cars.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class CarDataRepo : Repository<CarData>
    {
        public CarDataRepo(SampleDBContext context)
            : base(context)
        { }

        public List<CarData> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}