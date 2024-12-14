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
    public class ProductFeatureManager:IProductFeatureService
    {
        private readonly IProductFeatureDal _dal;

        public ProductFeatureManager(IProductFeatureDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(ProductFeature entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<ProductFeature>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<ProductFeature>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<ProductFeature, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<ProductFeature?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<ProductFeature?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<ProductFeature, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(ProductFeature entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(ProductFeature entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
