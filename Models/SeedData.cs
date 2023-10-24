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
                        Name = "admin@gmail.com",
                        PhoneNumber = 9999999999,
                        DateOfBirth = DateTime.Now.AddYears(-10),
                        DateOfJoining = DateTime.Now,
                        Password = "admin"
                    };

                    await context.Users.AddAsync(user);
                    await context.SaveChangesAsync();

                    if (!await context.UserRoles.AnyAsync())
                    {
                        var roles = new UserRole()
                        {
                            Role = "Admin"
                        };
                        await context.UserRoles.AddAsync(roles);
                        await context.SaveChangesAsync();

                        if (!await context.UserRoleMappings.AnyAsync())
                        {
                            var userRoleMapping = new UserRoleMapping()
                            {
                                UserId = user.Id,
                                RoleId = roles.Id
                            };

                            await context.UserRoleMappings.AddAsync(userRoleMapping);
                            await context.SaveChangesAsync();
                        }
                    }
                }



            }
        }
    }
}