using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> BusinessGetAllAsync(bool trackChanges);
        Task<IEnumerable<T>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<T, bool>>? expression = null, string[]? includes = null);
        Task<T?> BusinessGetByIdAsync(int id, bool trackChanges);
        Task<T?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<T, bool>>? expression = null, string[]? includes = null);
        Task BusinessCreateAsync(T entity);
        Task BusinessUpdateAsync(T entity);
        Task BusinessRemoveAsync(T entity);
    }
}
