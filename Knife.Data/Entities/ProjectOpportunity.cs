﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knife.Core.Entities.Foundation;

namespace Knife.Data.Entities
{
	public class ProjectOpportunity : AuditableEntity<int>
	{
		public string Name { get; set; }
		public string Owner { get; set; }
		public string Contact { get; set; }
		public string Descript { get; set; }
	}
}
