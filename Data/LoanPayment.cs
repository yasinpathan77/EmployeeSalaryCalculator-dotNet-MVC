using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Data
{
    public class LoanPayment : BaseEntity
    {
        public int Amount { get; set; }

        [ForeignKey("Salary")]
        public int? SalaryId { get; set; }

        public Salary? Salary { get; set; }
    }
}