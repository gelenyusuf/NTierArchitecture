using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Order:BaseEntity
	{
		public string ShippingAddress { get; set; }

		public int? AppUserID { get; set; }

		

		//Relatioanl Properties

		public virtual AppUser AppUser { get; set; }
		public virtual List<OrderDetail> OrderDetails { get; set; }
		
	}
}
