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
    public class LatestDiscountManager:ILatestDiscountService
    {
        private readonly ILatestDiscountDal _dal;

        public LatestDiscountManager(ILatestDiscountDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(LatestDiscount entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<LatestDiscount>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<LatestDiscount>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<LatestDiscount, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<LatestDiscount?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<LatestDiscount?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<LatestDiscount, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(LatestDiscount entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(LatestDiscount entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
