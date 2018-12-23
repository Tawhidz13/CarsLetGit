

using Cars.Controllers;
using Cars.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class CarData
    {
        SampleDBContext context = new SampleDBContext();



        public Car Get(int id)
        {

            return context.Cars.SingleOrDefault(i => i.ID == id);
        }

        public int Insert(Car c)
        {
            context.Cars.Add(c);
            return context.SaveChanges();
        }
        public int Delete(Car c)
        {
            context.Cars.Remove(c);
            return context.SaveChanges();
        }
        public int Update(Car c)
        {
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        
    }
}
