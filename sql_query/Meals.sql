
USE lab3_mvc;

CREATE TABLE Meals(
    Meal_Id INT PRIMARY KEY IDENTITY(1,1), 
    Customer_Id INT FOREIGN KEY REFERENCES Customers(Id),
    Staff_Id INT FOREIGN KEY REFERENCES Staffs(Staff_Id),  
    Date_Of_Meal NVARCHAR(200),
    Cost_Of_Meal NVARCHAR(50), 
    Other_Details NVARCHAR(50),
    CreatedBy NVARCHAR(200), 
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);


