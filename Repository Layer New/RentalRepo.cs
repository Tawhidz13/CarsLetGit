

using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{
    public class RentalRepo : Repository<Rental>, IRentalRepo
    {
        public RentalRepo(SampleDBContext context)
            : base(context)
        { }

        public List<Rental> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
