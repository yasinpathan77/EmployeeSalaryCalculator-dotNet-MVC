using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Namespace;

namespace EmployeeSalary.Data
{
    public class Address : BaseEntity
    {
        public string? Line { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public User? User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}