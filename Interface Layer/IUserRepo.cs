
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers//package name//change it
{
    public interface IUserRepo
    {
        List<User> GetAll();
        User Get(int id);
        int Insert(User c);
        int Delete(User c);
        int Update(User c);
    }
}
