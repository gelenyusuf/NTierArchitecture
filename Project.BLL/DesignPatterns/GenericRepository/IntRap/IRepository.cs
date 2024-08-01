using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRap
{
	public interface IRepository<T> where T:BaseEntity
	{
		//Listeleme(raporlama) komutları
		List<T> GetAll();//Bu metot ilgili T neyse o yapıdaki tüm verileri getirir.
		List<T> GetActives();//Bu metot ilgili T neyse sadece aktif kullanımda olan veriler getirir.
		List<T> GetPassives();//Bu metot sadece Pasif olan verileri getirecek

		List<T> GetModifieds();//Bu metot sadece güncellenmiş verileri getirecek




		//Değişikik yaratma komutları (Modifiers)

		void Add(T item); //ekleme
		void AddRange(List<T> list);//liste halinde ekleme

		void Update(T item); //güncelleme

		void UpdateRange(List<T> list);
		void Delete(T item);//Veriyi pasifize eder
		void DeleteRange(List<T> list);

		void Destroy(T item); // bu metot veriyi yok eder.

		void DestroyRange(List<T> list);





		//Linq komutları (LINQ EXPRESSIONS): Dil ile entegre olmuş sorgudur.

		//Bir expression ifadesi iki kısımdan oluşur:x=>x.UnitPrice<20
		//1. kısım x=> ifadenin arguman kısmıdır.Lamda opertörü konulduğunda ilgili değişkeniniz Expressions destekleyen metottan önce hangi yapı geliyorsa 
		//onu tekil olarak alır(TSource) _db.Product.Where(x=> )
		//2.kısım x.UnitPrice<20 ifadenin sorgu kısmıdır.Mevcut durumda bool olarak ifade edilmiştir.
		//x=>x.UnitPrice <20 bu iki kısım birleştiği zaman sistemi tek  başına yönetebilecek bir delegate girerler.Delegate içerisine x alıp, bool ifadeye göre 
		//dışarıya bir sorgu sonucu döndürür.Bu delegate Expression tipi class sayesinde bir arguaman olarak bilinir.

		List<T> Where(Expression<Func<T, bool>> exp);

		bool Any(Expression<Func<T,bool>>exp);

		T FirstOrDefault(Expression<Func<T, bool>> exp);

		object Select(Expression<Func<T, object>> exp);
		IQueryable<X> Select<X>(Expression<Func<T, X>> exp);



		//Find
		T Find(int id);



		//Get Last Datas
		List<T> GetLastDatas(int number);



		//Get First Datas

		List<T> GetFirstDatas(int number);



		//Get Datas 

		List<T> GetCountedDatas(int number);



	}
}
