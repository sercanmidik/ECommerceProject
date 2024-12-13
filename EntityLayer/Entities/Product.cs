using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string? SliderTitle { get; set; }
        public string? SliderTitleTwo { get; set; }
        public string? SliderDescription { get; set; }
        public string? SliderImage { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscount { get; set; }
        public decimal DiscountRatio { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string? LongDescriptionTwo { get; set; }
        public string? LongDescriptionThree { get; set; }
        public bool IsStock { get; set; }
        public ICollection<MainSlider> MainSliders { get; set; }
        public ICollection<LatestDiscount> LatestDiscounts { get; set; }
        public ICollection<WeekProduct> WeekProducts { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }


    }
}
