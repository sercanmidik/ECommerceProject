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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _dal;

        public BrandManager(IBrandDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(Brand entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<Brand>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<Brand>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<Brand, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);   
        }

        public async Task<Brand?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<Brand?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<Brand, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges,expression,includes);
        }

        public async Task BusinessRemoveAsync(Brand entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(Brand entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
