﻿using BusinessLayer.Abstract;
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
    public class ServiceManager:IServiceService
    {
        private readonly IServiceDal _dal;

        public ServiceManager(IServiceDal dal)
        {
            _dal = dal;
        }

        public async Task BusinessCreateAsync(Service entity)
        {
            await _dal.CreateAsync(entity);
        }

        public async Task<IEnumerable<Service>> BusinessGetAllAsync(bool trackChanges)
        {
            return await _dal.GetAllAsync(trackChanges);
        }

        public Task<IEnumerable<Service>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<Service, bool>>? expression = null, string[]? includes = null)
        {
            return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
        }

        public async Task<Service?> BusinessGetByIdAsync(int id, bool trackChanges)
        {
            return await _dal.GetByIdAsync(id, trackChanges);
        }

        public async Task<Service?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<Service, bool>>? expression = null, string[]? includes = null)
        {
            return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
        }

        public async Task BusinessRemoveAsync(Service entity)
        {
            await _dal.RemoveAsync(entity);
        }

        public async Task BusinessUpdateAsync(Service entity)
        {
            await _dal.UpdateAsync(entity);
        }
    }
}
