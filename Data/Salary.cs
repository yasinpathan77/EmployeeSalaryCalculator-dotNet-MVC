using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Namespace;

namespace EmployeeSalary.Data
{
    public class Salary : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }

        public int Amount { get; set; }

        public string? Remark { get; set; }
    }
}