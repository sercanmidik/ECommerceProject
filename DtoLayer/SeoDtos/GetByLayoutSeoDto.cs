﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.SeoDtos
{
	public class GetByLayoutSeoDto
	{
		public string KeyWords { get; set; }
		public string Description { get; set; }
		public string ImageName { get; set; }
		public string Title { get; set; }
	}
}
