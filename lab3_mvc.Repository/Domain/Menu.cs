using System;
namespace lab3_mvc.Repository.Domain 
{ 
    public class Menu 
    { 
        public int Meal_Id { get; set; }
        public string Menu_Name { get; set; }
        public DateTime Available_Date_From { get; set; }
        public DateTime Available_Date_To { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
