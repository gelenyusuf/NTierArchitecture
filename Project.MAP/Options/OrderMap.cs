using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class OrderMap:BaseMap<Order>
	{
		public OrderMap()
		{
			ToTable("Siparişler");
			Property(x => x.ShippingAddress).HasColumnName("Gönderim Adresi");
		}

	}
}
