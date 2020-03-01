using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RCustomer;
namespace lab3_mvc.Services.SCustomer 
{ 
    public class CustomerService : GenericService<Customer>, ICustomerService 
    { 
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository) 
        {
        }
    }
} 