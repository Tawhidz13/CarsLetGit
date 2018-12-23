using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{
    public class AdminRepo
    {
        SampleDBContext context = new SampleDBContext();
        public List<Car> GetAll()
        {
            return context.Cars.ToList();
        }
           public Car Get(String id)
           {
               return context.Cars.SingleOrDefault(i => Convert.ToString(i.CarTypeID) == id);
           }
           
        public int Insert(Car e)
        {
            context.Cars.Add(e);
            return context.SaveChanges();
        }

        public int Delete(Car e)
        {
            context.Cars.Remove(e);
            return context.SaveChanges();
        }

        public int Update(Car e)
        {
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
