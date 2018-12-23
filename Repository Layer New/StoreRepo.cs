

using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository
{
    public class StoreRepo : Repository<Store>, IStoreRepo
    {
        public StoreRepo(SampleDBContext context)
            : base(context)
        { }

        public List<Store> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
