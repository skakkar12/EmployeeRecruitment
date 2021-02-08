using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIInMemoryDBSeededIRepository.Models
{
    public class EmployeeDBInitializer
    {
        public static void Seed(EmployeeDBContext context)
        {
            
                if (context.Employees.Any())
                {
                    return;
                }

                context.Employees.AddRange(
                new Employee
                {
                    Id = 1,
                    fName = "David",
                    lName = "Bowie",
                    age = 81,
                    address = "123 Main St",
                    city = "Hollywood",
                    JobDecision="Yes"
                },
                new Employee
                {
                    Id = 2,
                    fName = "Madonna",
                    lName = "Ciccone",
                    age = 61,
                    address = "332 Market St",
                    city = "Detroit",
                    JobDecision = "No"

                },
                new Employee
                {
                    Id = 3,
                    fName = "Cyndi",
                    lName = "Lauper",
                    age = 67,
                    address = "111 George St",
                    city = "Brooklyn",
                    JobDecision = "Yes"
                },
                new Employee
                {
                    Id = 4,
                    fName = "Samuel",
                    lName = "Cooper",
                    age = 67,
                    address = "111 George St",
                    city = "Brooklyn",
                    JobDecision = "Yes"
                },
                new Employee
                {
                    Id = 5,
                    fName = "Sara",
                    lName = "Leeper",
                    age = 62,
                    address = "111 George St",
                    city = "Brooklyn",
                    JobDecision = "No"
                }
                    );

                context.SaveChanges();
            
        }
    }
}
