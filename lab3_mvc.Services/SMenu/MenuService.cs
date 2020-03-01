using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RMenu;
namespace lab3_mvc.Services.SMenu 
{ 
    public class MenuService : GenericService<Menu>, IMenuService 
    { 
        public MenuService(IMenuRepository menuRepository) : base(menuRepository) 
        {
        }
    }
} 