using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RStaff;
namespace lab3_mvc.Services.SStaff 
{ 
    public class StaffService : GenericService<Staff>, IStaffService 
    { 
        public StaffService(IStaffRepository staffRepository) : base(staffRepository) 
        {
        }
    }
} 