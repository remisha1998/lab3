using Microsoft.Extensions.DependencyInjection;
using lab3_mvc.Services.SCustomer;
using lab3_mvc.Services.SMeal;
using lab3_mvc.Services.SMeal_Dish;
using lab3_mvc.Services.SMenu;
using lab3_mvc.Services.SMenu_Item;
using lab3_mvc.Services.SRef_Staff_Role;
using lab3_mvc.Services.SStaff;
namespace lab3_mvc.Services 
{ 
    public static class ServicesModule 
    { 
        public static void Register(IServiceCollection services) 
        { 
            services.AddTransient<ICustomerService, CustomerService>(); 
            services.AddTransient<IMealService, MealService>(); 
            services.AddTransient<IMeal_DishService, Meal_DishService>(); 
            services.AddTransient<IMenuService, MenuService>(); 
            services.AddTransient<IMenu_ItemService, Menu_ItemService>(); 
            services.AddTransient<IRef_Staff_RoleService, Ref_Staff_RoleService>();
            services.AddTransient<IStaffService, StaffService>(); 
            


            


        }
    }
}