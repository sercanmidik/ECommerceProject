using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class LatestDiscount
    {
        public int LatestDiscountId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
