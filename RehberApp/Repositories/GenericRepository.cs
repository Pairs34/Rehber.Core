using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RehberApp.Contexts;
using RehberApp.Entities;

namespace RehberApp.Repositories
{
    public class GenericRepository<T> where T:class,new()
    {
        public void Add(T table)
        {
            using (var context = new SqlContext())
            {
                context.Set<T>().Add(table);
                context.SaveChanges();
            }
        }

        public void Update(T table)
        {
            using (var context = new SqlContext())
            {
                context.Set<T>().Update(table);
                context.SaveChanges();
            }
        }

        public void Delete(T table)
        {
            using (var context = new SqlContext())
            {
                context.Set<T>().Remove(table);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new SqlContext())
            {
                return context.Set<T>().OrderByDescending(x => x).ToList();
            }
        }

        public T GetById(int Id)
        {
            using (var context = new SqlContext())
            {
                return context.Set<T>().Find(Id);
            }
        }
    }
}
