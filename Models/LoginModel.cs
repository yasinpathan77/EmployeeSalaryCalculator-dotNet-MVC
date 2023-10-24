using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Models
{
    public class LoginModel
    {
        [Required]
        [RegularExpression(pattern: @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please Enter a valid phone number")]
        public long? PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? ErrorMessage { get; set; }
    }
}