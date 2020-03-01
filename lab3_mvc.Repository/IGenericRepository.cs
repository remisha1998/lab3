using System.Linq;
namespace lab3_mvc.Repository 
{ 
    public interface IGenericRepository<T> 
    {
        T Get(int id);
        IQueryable<T> Query();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
} 