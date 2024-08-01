using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class OrderDetail:BaseEntity
	{
		public int ProductID { get; set; }
		public int OrderID { get; set; }
	}
}
