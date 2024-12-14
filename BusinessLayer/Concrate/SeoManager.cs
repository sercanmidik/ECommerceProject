using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.SeoDtos;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class SeoManager:ISeoService
	{
		private readonly ISeoDal _dal;

		public SeoManager(ISeoDal dal)
		{
			_dal = dal;
		}

		public async Task BusinessCreateAsync(Seo entity)
		{
			await _dal.CreateAsync(entity);
		}

		public async Task<IEnumerable<Seo>> BusinessGetAllAsync(bool trackChanges)
		{
			return await _dal.GetAllAsync(trackChanges);
		}

		public Task<IEnumerable<Seo>?> BusinessGetAllWhereWithInculudeAsync(bool trackChanges, Expression<Func<Seo, bool>>? expression = null, string[]? includes = null)
		{
			return _dal.GetAllWhereWithInculudeAsync(trackChanges, expression, includes);
		}

		public async Task<Seo?> BusinessGetByIdAsync(int id, bool trackChanges)
		{
			return await _dal.GetByIdAsync(id, trackChanges);
		}

		public async Task<Seo?> BusinessGetByIdInculudeAsync(bool trackChanges, Expression<Func<Seo, bool>>? expression = null, string[]? includes = null)
		{
			return await _dal.GetByIdInculudeAsync(trackChanges, expression, includes);
		}

		public async Task BusinessRemoveAsync(Seo entity)
		{
			await _dal.RemoveAsync(entity);
		}

		public async Task BusinessUpdateAsync(Seo entity)
		{
			await _dal.UpdateAsync(entity);
		}

		public async Task<GetByLayoutSeoDto> GetByLayoutSeo()
		{
			var value = await _dal.GetByIdInculudeAsync(false);
			return value != null ? new GetByLayoutSeoDto
			{
				Description = value.Description,
				ImageName = value.ImageName,
				KeyWords = value.KeyWords,
				Title=value.Title,
			} : new GetByLayoutSeoDto();
		}
	}
}
