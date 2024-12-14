using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Seo
	{
        public int SeoId { get; set; }
        public string KeyWords { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string Title { get; set; }
    }
}
