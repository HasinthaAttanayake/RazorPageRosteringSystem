using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPageRosteringSystem.Data;
using System;
using System.Linq;

namespace RazorPageRosteringSystem.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageRosteringSystemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageRosteringSystemContext>>()))
            {
                // Look for any Staff or Roles
                if (context.Role.Any())
                {
                    return;   // DB has been seeded
                }
                // Seed Entire DB
                context.Role.AddRange(
                    new Role
                    {
                        name = "Resturant Manager",
                        description = "Manages KFC Restaurant",
                        ratehr = 35.29M
                    },
                    new Role
                    {
                        name = "Assistant Manager",
                        description = "Helps restaurant manager manage KFC Restaurant",
                        ratehr = 29.50M
                    },
                    new Role
                    {
                        name = "Cook",
                        description = "Prepares Meals",
                        ratehr = 21.20M
                    },
                    new Role
                    {
                        name = "Customer Service",
                        description = "Takes orders and helps customers",
                        ratehr = 23.40M
                    },
                    new Role
                    {
                        name = "Cleaner",
                        description = "Cleans KFC Restaurant",
                        ratehr = 25.10M
                    }
                );
                context.SaveChanges();

                //define local non-static function to get foreign key from DB
                int getRoleFK(string roleName) {

                    var query = from r in context.Role
                               where r.name == roleName
                               select r.roleID;
                    int FK = query.FirstOrDefault();
                    return FK; 
                };

                context.Staff.AddRange(
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Hasi",
                        address = "112 asdas NSW",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144490",
                        roleID = getRoleFK("Cleaner")
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
