

using Cars.Controllers;
using Cars.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class Repository<Gen> : IRepository<Gen> where Gen : Entity
    {
        //Temporary
        SampleDBContext context;

        public SampleDBContext Context
        {
            get { return context; }
        }

        public Repository(SampleDBContext context)
        {
            this.context = context;
        }

        public List<Gen> GetAll()
        {
            return Context.Set<Gen>().ToList();
        }

        public Gen Get(int id)
        {
            return Context.Set<Gen>().Find(id);
        }

        public int Insert(Gen g)
        {
            Context.Set<Gen>().Add(g);
            return Context.SaveChanges();
        }

        public int Update(Gen g)
        {
            Context.Entry<Gen>(g).State = System.Data.Entity.EntityState.Modified;
            return Context.SaveChanges();
        }

        public int Delete(Gen g)
        {
            Context.Set<Gen>().Remove(g);
            return Context.SaveChanges();
        }
    }
}
