using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ProductFeature
    {
        public int ProductFeatureId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int FeautureId { get; set; }
        public Feature Feature { get; set; }
        public string FeatureValue { get; set; }
    }
}
