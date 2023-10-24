using EmployeeSalary.Models;
using Namespace;

namespace EmployeeSalary.Services
{
    public interface IUserService
    {
        Task<User> CheckUserCredentials(LoginModel model);
    }
}