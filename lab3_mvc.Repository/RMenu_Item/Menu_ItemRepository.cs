using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RMenu_Item 
{ 
    public class Menu_ItemRepository : GenericRepository<Menu_Item>, IMenu_ItemRepository 
    { 
        public Menu_ItemRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 