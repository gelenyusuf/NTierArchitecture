using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Project.MAP.Options
{
	//Ayarlamaları yapmakla görevli sınıfımız aslında EntityTypeConfiguration  isimli generic sınıftır.Bu sınıf çağırıldığı zaman (dikkat etmeliyiz ki
	//aşağıda miras almak için çağırmaktayız.) generic tipinin belirlenmesini veya belirlenemiyorsa devam ettirilmesini sağlamak gerekir.Dikkat edersek 
	//aşağıda EntityTypeConfigurations classını miras almak için çağırdığımız zaman generic tipini belirleyemiyoruz.Çünkü eğer belirlemek istersek
	//tüm veritabanı ayarlama işlemlerimiz sadece belirlediğimiz o sınıf üzerinden yapılır.Asıl istediğimiz EntityTypeConfigurations sınıfının çağırıldığı 
	//yerde genericliğini devam ettirmesi.Ancak generic bir sınıf çağırılırsa genericliğini elimizde bir generic yapı olmadan devam ettiremez.
	
	public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T:BaseEntity
	{
		public BaseMap()
		{
			Property(x => x.CreatedDate).HasColumnName("Yaratılam Tarihi");   //Veritabanında kolon ismi değiştirme
			Property(x=>x.ModifiedDate).HasColumnName("Guncelleme Tarihi");
			Property(x=>x.DeletedDate).HasColumnName("Silme Tarihi");
			Property(x => x.Status).HasColumnName("Veri Durumu");

			
		}
	}
}
