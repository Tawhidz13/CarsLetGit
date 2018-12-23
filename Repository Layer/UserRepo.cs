using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{
    public class CustomerRepo
    {
        SampleDBContext context = new SampleDBContext();
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
        public User Get(String id)
        {
            return context.Users.SingleOrDefault(i => i.UserID == id);
        }
        public int Insert(User e)
        {
            context.Users.Add(e);
           // context.Logins.Add(l);
            return context.SaveChanges();
        }

        public int Delete(User e)
        {
            context.Users.Remove(e);
            return context.SaveChanges();
        }

        public int Update(User e)
        {
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
