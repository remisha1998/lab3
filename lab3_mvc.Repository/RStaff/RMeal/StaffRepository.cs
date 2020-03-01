using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RStaff 
{ 
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository 
    { 
        public StaffRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 