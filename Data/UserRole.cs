using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Data
{
    public class UserRole : BaseEntity
    {
        [Required]
        public string? Role { get; set; }

    }
}