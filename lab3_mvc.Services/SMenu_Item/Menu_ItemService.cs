using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RMenu_Item;
namespace lab3_mvc.Services.SMenu_Item 
{ 
    public class Menu_ItemService : GenericService<Menu_Item>, IMenu_ItemService 
    { 
        public Menu_ItemService(IMenu_ItemRepository menu_itemRepository) : base(menu_itemRepository) 
        {
        }
    }
} 