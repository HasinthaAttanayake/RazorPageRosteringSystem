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
                        name = "Hasintha Attanayake",
                        address = "10 George Street Sydney 2000",
                        dateOfBirth = DateTime.Parse("02-09-1994"),
                        email = "hasi@gmail.com",
                        mob = "0430144491",
                        roleID = getRoleFK("Resturant Manager")
                    },
                    new Staff
                    {
                        name = "John Smith",
                        address = "230 Sussex Street Sydney 2000",
                        dateOfBirth = DateTime.Parse("22-01-1983"),
                        email = "johns123@yahoo.com",
                        mob = "0423444490",
                        roleID = getRoleFK("Assistant Manager")
                    },
                    new Staff
                    {
                        name = "Janice Bing",
                        address = "1544/20 Pitt Street Sydney 2000",
                        dateOfBirth = DateTime.Parse("01-05-2000"),
                        email = "jbing21@gmail.com",
                        mob = "0426893102",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Lorry Samuels",
                        address = "112 Merryville Place Merrylands 2197",
                        dateOfBirth = DateTime.Parse("09-02-2003"),
                        email = "LSam03@gmail.com",
                        mob = "0378123948",
                        roleID = getRoleFK("Cook")
                    },
                    new Staff
                    {
                        name = "Isabelle Morales",
                        address = "98 The Ponds Boulevard The Ponds 2769",
                        dateOfBirth = DateTime.Parse("22-03-1999"),
                        email = "MoralesIsabella@optusnet.com.au",
                        mob = "0420193084",
                        roleID = getRoleFK("Customer Service")
                    },
                    new Staff
                    {
                        name = "Jeoffory Bezoz",
                        address = "99/123 Martin Place Sydney 2000",
                        dateOfBirth = DateTime.Parse("12-10-1964"),
                        email = "jbee64@amazon.com",
                        mob = "0416738940",
                        roleID = getRoleFK("Cleaner")
                    },
                    new Staff
                    {
                        name = "Elon Musk",
                        address = "21 Murants Lane Glenwood 2183",
                        dateOfBirth = DateTime.Parse("28-07-1971"),
                        email = "elon@muskindustries.com",
                        mob = "0421930482",
                        roleID = getRoleFK("Customer Service")
                    },
                    new Staff
                    {
                        name = "Mary London",
                        address = "12/32 Reid Street Westmead 2834",
                        dateOfBirth = DateTime.Parse("21-11-1998"),
                        email = "MaryL98@gmail.com",
                        mob = "0943139489",
                        roleID = getRoleFK("Customer Service")
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
