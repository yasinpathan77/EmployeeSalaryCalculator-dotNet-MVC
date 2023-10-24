using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Services
{
    public interface IUserAuthenticationService
    {
        bool IsUserLoggedIn();
    }
}