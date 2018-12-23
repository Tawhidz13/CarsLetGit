using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public interface IRepository<Gen> where Gen : Entity
    {
        List<Gen> GetAll();
        Gen Get(int id);
        int Insert(Gen g);
        int Update(Gen g);
        int Delete(Gen g);
    }
}