
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class CarRepo : IcarRepo
    {
        SampleDBContext context = new SampleDBContext();

      

        public Car Get(int id)
        {

            return context.Cars.SingleOrDefault(i => i.ID == id);
        }

        public int Insert(User c)
        {
            context.Users.Add(c);
            return context.SaveChanges();
        }
        public int Delete(User c)
        {
            context.Users.Remove(c);
            return context.SaveChanges();
        }
        public int Update(User c)
        {
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        List<Car> IcarRepo.GetAll()
        {
            throw new NotImplementedException();
        }

        Car IcarRepo.Get(int id)
        {
            throw new NotImplementedException();
        }

        int IcarRepo.Insert(Car c)
        {
            throw new NotImplementedException();
        }

        int IcarRepo.Delete(Car c)
        {
            throw new NotImplementedException();
        }

        int IcarRepo.Update(Car c)
        {
            throw new NotImplementedException();
        }
    }
}
