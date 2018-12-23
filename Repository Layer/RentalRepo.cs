

using Cars.Controllers;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleRepository
{
    public class LoginRepo
    {
        SampleDBContext context = new SampleDBContext();
        public List<Rental> GetAll()
        {
            return context.Rentals.ToList();
        }
        public Rental Get(int id) //id int32
        {
            return context.Rentals.SingleOrDefault(i => i.RentalID == id);
        }
        public int Insert(Rental e)
        {
            context.Rentals.Add(e);
            return context.SaveChanges();
        }

        public int Delete(Rental e)
        {
            context.Rentals.Remove(e);
            return context.SaveChanges();
        }

        public int Update(Rental e)
        {
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
