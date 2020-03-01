using System.Collections.Generic; 
using System.Linq; 
using lab3_mvc.Repository;
namespace lab3_mvc.Services 
{ 
    public abstract class GenericService<T> : IGenericService<T> 
        where T : class, new() 
        { 
            protected GenericService(IGenericRepository<T> entityRepository) 
            { 
                EntityRepository = entityRepository; 
            }
        protected IGenericRepository<T> EntityRepository { get; set; }
                 public void Insert(T entity) 
                    { 
                    EntityRepository.Insert(entity); 
                    }
                public void Update(T entity) 
                    { 
                    EntityRepository.Update(entity); 
                    }
                public IList<T> GetAll() 
                    { 
                    return EntityRepository.Query().ToList(); 
                    }
                public T GetById(int id) 
                { 
                    return EntityRepository.Get(id); 
                        
                }
                public void Delete(T entity) 
                { 
                    EntityRepository.Delete(entity); 
                }
        }
}