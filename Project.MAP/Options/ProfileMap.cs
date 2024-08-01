using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Options
{
	public class ProfileMap:BaseMap<AppUserProfile>
	{
		public ProfileMap()
		{
			ToTable("Profiller");
			Property(x => x.FirstName).HasColumnName("Isim").IsRequired();
			Property(x=>x.LastName).HasColumnName("SoyIsim").IsRequired();
		}
	}
}
