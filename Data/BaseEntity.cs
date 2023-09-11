using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Deleted { get; set; }
    }
}