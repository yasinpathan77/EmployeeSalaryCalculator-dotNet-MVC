using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Namespace;

namespace EmployeeSalary.Data
{
    public class UserRoleMapping
    {
        [Column(Order = 1)]
        [ForeignKey("User")]
        [Key]
        public int UserId { get; set; }

        public User? User { get; set; }

        [Column(Order = 2)]
        [ForeignKey("UserRole")]
        [Key]
        public int RoleId { get; set; }

        public UserRole? UserRole { get; set; }

    }
}