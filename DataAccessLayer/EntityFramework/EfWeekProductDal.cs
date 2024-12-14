using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWeekProductDal : GenericRepository<WeekProduct>, IWeekProductDal
    {
        public EfWeekProductDal(ECommerceDbContext context) : base(context)
        {
        }
    }
}
