using System.Linq.Expressions;
namespace reactTodoBackend.Repo
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
        List<T> GetWhere(Expression<Func<T, bool>> method);
        List<T> GetAll(Expression<Func<T, bool>> method);
    }
}