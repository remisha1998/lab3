using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RCustomer 
{ 
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository 
    { 
        public CustomerRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 