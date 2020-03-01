using Microsoft.EntityFrameworkCore; 
using Microsoft.Extensions.DependencyInjection; 
using lab3_mvc.Repository.RCustomer;
using lab3_mvc.Repository.RMeal;
using lab3_mvc.Repository.RMeal_Dish;
using lab3_mvc.Repository.RMenu;
using lab3_mvc.Repository.RMenu_Item;
using lab3_mvc.Repository.RRef_Staff_Role;
using lab3_mvc.Repository.RStaff;

namespace lab3_mvc.Repository 
{ 
    public static class RepositoryModule 
    { 
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly) 
        {
            services.AddDbContext<RestaurantContext>(options =>
             options.UseSqlServer(connection, builder => 
             builder.MigrationsAssembly(migrationsAssembly))); 
                
            services.AddTransient<ICustomerRepository, CustomerRepository>();
                services.AddTransient<IMealRepository, MealRepository>();
                services.AddTransient<IMeal_DishRepository, Meal_DishRepository>();
                services.AddTransient<IMenuRepository, MenuRepository>();
                services.AddTransient<IMenu_ItemRepository, Menu_ItemRepository>();
                services.AddTransient<IRef_Staff_RoleRepository, Ref_Staff_RoleRepository>();
                services.AddTransient<IStaffRepository, StaffRepository>();


        }
    }
}