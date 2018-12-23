
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ProductMSEntity;

namespace Cars.Controllers
{
    public interface ISearch<Gen> where Gen : Entity
    {
        List<Gen> Search(string key);


    }
}
