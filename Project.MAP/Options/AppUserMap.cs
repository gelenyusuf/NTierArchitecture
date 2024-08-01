using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class AppUserMap:BaseMap<AppUser>
	{
		public AppUserMap()
		{
			ToTable("Kullanıcılar");
			Property(x=>x.UserName).HasColumnName("Kullanıcı İsmi").IsRequired();
			Property(x => x.Password).HasColumnName("Sifre").IsRequired();

			//iLİŞKİ AYARLAMALARI

			HasOptional(x => x.Profile).WithRequired(x => x.AppUser);//Birebir ilişki ayarlaması bu şekilde tanımlanmakta.

		}
	}
}
