using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RRef_Staff_Role;
namespace lab3_mvc.Services.SRef_Staff_Role 
{ 
    public class Ref_Staff_RoleService : GenericService<Ref_Staff_Role>, IRef_Staff_RoleService 
    { 
        public Ref_Staff_RoleService(IRef_Staff_RoleRepository ref_staff_roleRepository) : base(ref_staff_roleRepository) 
        {
        }
    }
} 