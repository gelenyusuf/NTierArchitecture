using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class CategoryMap:BaseMap<Category>
	{
		public CategoryMap()
		{
			ToTable("Kategoriler");//Tablo İsmi artık Kategoriler olsun.
			Property(x => x.CategoryName).HasColumnName("Kategori Adı").IsRequired();//IsRequired() metodu bir sütunun sql'de null geçilmemesini sağlar 
			Property(x => x.Description).HasColumnName("Açıklama");
		}
	}
}
