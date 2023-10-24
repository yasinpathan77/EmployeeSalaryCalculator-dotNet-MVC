using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmployeeSalary.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetEntityByConditionAsync(Expression<Func<TEntity, bool>> predicate);
    }
}