using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class 
    {
        private readonly ECommerceDbContext _context;

        public GenericRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<T>> GetAllAsync(bool trackChanges)
        {
            var result = trackChanges? _context.Set<T>().ToListAsync(): _context.Set<T>().AsNoTracking().ToListAsync();
            return result.ContinueWith(task => (IEnumerable<T>)task.Result);
        }

        public async Task<IEnumerable<T>?> GetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<T, bool>>? expression = null, string[]? includes = null)
        {
            IQueryable<T> data = expression != null ? _context.Set<T>().Where(expression) : _context.Set<T>();
            if (!trackChanges)
            {
                data = data.AsNoTracking(); // Veriler izlenmesin
            }
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    data = data.Include(item);
                }
            }
            return await data.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id, bool trackChanges)
        {
            if (trackChanges)
            {
                return await _context.Set<T>().FindAsync(id);
            }
            else
            {
                return await _context.Set<T>()
                                     .AsNoTracking()
                                     .FirstOrDefaultAsync(entity => EF.Property<int>(entity, "Id") == id);
            }
        }

        public async Task<T?> GetByIdInculudeAsync(bool trackChanges, Expression<Func<T, bool>>? expression = null, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (!trackChanges)
            {
                query = query.AsNoTracking();
            }
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
