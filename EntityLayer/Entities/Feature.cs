using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}
