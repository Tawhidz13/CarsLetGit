

using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository
{
    public class RentalRepo : IRentalRepo
    {
        SampleDBContext context = new SampleDBContext();

        public List<Rental> GetAll()
        {
            return context.Rentals.ToList();
        }

        public Rental Get(int id)
        {

            return context.Rentals.SingleOrDefault(i => i.RentalID == id);
        }

        public int Insert(Rental c)
        {
            context.Rentals.Add(c);
            return context.SaveChanges();
        }
        public int Delete(Rental c)
        {
            context.Rentals.Remove(c);
            return context.SaveChanges();
        }
        public int Update(Rental c)
        {
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        
    }
}
