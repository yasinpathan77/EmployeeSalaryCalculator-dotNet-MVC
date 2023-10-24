using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EmployeeSalary.Data;
using Microsoft.DotNet.Scaffolding.Shared;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSalary.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly EmployeeSalaryDbContext _dbProvider;
        public Repository(EmployeeSalaryDbContext dbProvider)
        {
            _dbProvider = dbProvider;
        }
        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbProvider.Set<TEntity>().Where(predicate).ToListAsync();
        }
        public async Task<TEntity> GetEntityByConditionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return (await _dbProvider.Set<TEntity>().Where(predicate).FirstOrDefaultAsync())!;
        }
    }
}