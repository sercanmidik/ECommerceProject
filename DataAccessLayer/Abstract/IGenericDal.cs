using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{ 
    public interface IGenericDal<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<T>?> GetAllWhereWithInculudeAsync(bool trackChanges,Expression<Func<T, bool>>? expression = null, string[]? includes = null);
        Task<T?> GetByIdAsync(int id, bool trackChanges);
        Task<T?> GetByIdInculudeAsync(bool trackChanges,Expression<Func<T, bool>>? expression = null, string[]? includes = null);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
