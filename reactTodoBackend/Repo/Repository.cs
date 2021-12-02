using System.Linq.Expressions;
using System;
namespace reactTodoBackend.Repo{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(){
            
        }
        public void Delete(object Id)
        {
           
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public T GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }


}