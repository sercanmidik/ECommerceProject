using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(Product entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<Product>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<Product>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<Product, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<Product?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<Product?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<Product, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(Product entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(Product entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
