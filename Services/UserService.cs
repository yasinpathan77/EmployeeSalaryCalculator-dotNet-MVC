using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSalary.Models;
using EmployeeSalary.Repository;
using Namespace;

namespace EmployeeSalary.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;

        }

        public async Task<User> CheckUserCredentials(LoginModel model)
        {
            return await _userRepository.GetEntityByConditionAsync(x => x.PhoneNumber == model.PhoneNumber && x.Password == model.Password);
        }
    }
}