using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{
    public class AdminRepo : Repository<Admin>//, ISearch<Admin>
    {
        public AdminRepo(SampleDBContext context)
            : base(context)
        { }
    }
    
}
