using System;
namespace lab3_mvc.Repository.Domain 
{ 
    public class Staff 
    { 
        public int Staff_Id { get; set; }
        public int Staff_Role_Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
