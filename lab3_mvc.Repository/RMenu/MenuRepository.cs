using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RMenu 
{ 
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository 
    { 
        public MenuRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 