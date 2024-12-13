using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string NameTwo { get; set; }
        public string ImageName { get; set; }
        public string? ClassName { get; set; }
    }
}
