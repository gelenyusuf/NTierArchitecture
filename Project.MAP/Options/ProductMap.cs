using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class ProductMap:BaseMap<Product>
	{
		//Eğer bir tipin ayarlamasını özel olarak belirtmemişsek o tip bir değer tipiyse sql null geçilemez gider referans tipiyse sql null geçilebilir gider.
		//Eğer bir değer tipinin sqle null geçileblir gitmesini istersek o tip hibritleştiririz.
		public ProductMap()
		{
			ToTable("Ürünler");
			Property(x=>x.ProductName).HasColumnName("Ürün İsmi");
			Property(x=>x.UnitPrice).HasColumnName("Fiyat").HasColumnType("money");
		}
	}
}
