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
    public class WeekProductManager:IWeekProductService
    {
        private readonly IWeekProductDal _dal;

        public WeekProductManager(IWeekProductDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(WeekProduct entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<WeekProduct>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<WeekProduct>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<WeekProduct, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<WeekProduct?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<WeekProduct?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<WeekProduct, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(WeekProduct entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(WeekProduct entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
