namespace mySmartWallet2022.Models.Data.Entities
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "Igben",
                    LastName = "Titus",
                    MiddleName = "Eddy",
                    gender = GenderEnum.male,
                    MaritalStatus= MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "Nigeria",
                    State = "Delta",
                    City ="Warri",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Eddy",
                    LastName = "Joshua",
                    MiddleName = "Kimmich",
                    gender = GenderEnum.Female,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "England",
                    State = "London",
                    City = "Manhattan",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }
        
        }
    }
}
