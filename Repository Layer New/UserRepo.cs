using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{

    public class UserRepo : Repository<User>
    {
        public UserRepo(SampleDBContext context)
            : base(context)
        { }

       
    }
}
