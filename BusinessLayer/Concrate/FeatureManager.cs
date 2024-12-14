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
    public class FeatureManager:IFeatureService
    {
        private readonly IFeatureDal _dal;

        public FeatureManager(IFeatureDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(Feature entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<Feature>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<Feature>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<Feature, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<Feature?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<Feature?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<Feature, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(Feature entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(Feature entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
