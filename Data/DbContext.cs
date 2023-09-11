using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Namespace;

namespace EmployeeSalary.Data
{
    public class EmployeeSalaryDbContext : DbContext
    {
        public EmployeeSalaryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<LoanPayment> LoanPayments { get; set; }

        public DbSet<Salary> Salaries { get; set; }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoleMapping>().HasKey(x => new { x.UserId, x.RoleId });
            base.OnModelCreating(modelBuilder);
        }
    }
}