
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers//package name//change it
{
    public interface IAdmin : IRepository<Admin>, ISearch<Admin>
    {

    }
}
