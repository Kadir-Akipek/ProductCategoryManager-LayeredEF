using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
	//Abstract(IGenericDal) içindeki CRUD metotlarını dolduracağız
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		KampContext context = new KampContext();
		private readonly DbSet<T> _object;


		//GenericRepository class'ı çağırıldığı anda object'de nesne
		//örneği oluştur ve bu object'e context'ten gelen entity'i ata
		public GenericRepository() 
        {
			_object = context.Set<T>();
        }

        public void Delete(T entity)
		{
			var deletedEntity = context.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			context.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _object.ToList();
		}

		public T GetById(int id)
		{
			return _object.Find(id);
		}

		public void Insert(T entity)
		{
			//context.Entry ile ekleme işlemi yapacağımız entity'i hafızaya çekiyoruz 
			var addedEntity = context.Entry(entity); 
			addedEntity.State = EntityState.Added; //ekleme işlemi gerçekleştirdik
			context.SaveChanges();
		}

		public void Update(T entity)
		{
			var updatedEntity = context.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}
