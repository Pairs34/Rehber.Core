using System.Collections.Generic;

namespace RehberApp.Interfaces
{
    public interface IGenericRepository<T> where T : class,new()
    {
        public void Add(T table);
        public void Update(T table);
        public void Delete(T table);
        public List<T> GetAll();
        public T GetById(int Id);
    }
}