using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSalary.Data;
using Microsoft.EntityFrameworkCore;
using Namespace;

namespace EmployeeSalary.Models
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeSalaryDbContext(serviceProvider.GetRequiredService<DbContextOptions<EmployeeSalaryDbContext>>()))
            {
                if (await context.Users.AnyAsync()) return;
                else
                {
                    var user = new User()
                    {
                        Name = "Admin",
                        PhoneNumber = 0,
                        DateOfBirth = DateTime.Now.AddYears(-10),
                        DateOfJoining = DateTime.Now,
                        AddressId = 0
                    };

                }
            }
        }
    }
}