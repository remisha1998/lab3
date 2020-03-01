using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RRef_Staff_Role 
{ 
    public class Ref_Staff_RoleRepository : GenericRepository<Ref_Staff_Role>, IRef_Staff_RoleRepository 
    { 
        public Ref_Staff_RoleRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 