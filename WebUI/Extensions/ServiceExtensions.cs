using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.Design;

namespace WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // DbContext ve Identity
            services.AddDbContext<ECommerceDbContext>();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ECommerceDbContext>().AddDefaultTokenProviders();


            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<ILatestDiscountService, LatestDiscountManager>();
            services.AddScoped<ILatestDiscountDal, EfLatestDiscountDal>();
            services.AddScoped<IMainSliderService, MainSliderManager>();
            services.AddScoped<IMainSliderDal, EfMainSliderDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductFeatureService, ProductFeatureManager>();
            services.AddScoped<IProductFeatureDal, EfProductFeatureDal>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IWeekProductService, WeekProductManager>();
            services.AddScoped<IWeekProductDal, EfWeekProductDal>();
			services.AddScoped<ISeoService, SeoManager>();
			services.AddScoped<ISeoDal, EfSeoDal>();
			return services;
        }

        public static void ConfigureApplicationCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
            });
        }
    }
}
