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
    public class MainSliderManager:IMainSliderService
    {
        private readonly IMainSliderDal _dal;

        public MainSliderManager(IMainSliderDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(MainSlider entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<MainSlider>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<MainSlider>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<MainSlider, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<MainSlider?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<MainSlider?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<MainSlider, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(MainSlider entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(MainSlider entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
