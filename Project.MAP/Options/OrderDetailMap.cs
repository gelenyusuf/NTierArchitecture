using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class OrderDetailMap:BaseMap<OrderDetail>
	{
		public OrderDetailMap()
		{
			ToTable("Satışlar");
			//İLİŞKİ AYARLAMALARI

			Ignore(x=>x.ID);
			HasKey(x=>new { 
			
			x.OrderID,
			x.ProductID
			});
		}
	}
}
