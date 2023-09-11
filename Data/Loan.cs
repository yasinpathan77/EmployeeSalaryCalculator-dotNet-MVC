using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Data
{
    public class Loan : BaseEntity
    {
        public int Amount { get; set; }

        public string? Remark { get; set; }

        public DateTime? Complete { get; set; }
    }
}