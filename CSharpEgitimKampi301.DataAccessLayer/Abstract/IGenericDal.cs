using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class //dışarıdan bir T değeri alacaksın ve bu T değeri class olmak zorunda
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetAll();
		T GetById(int id);
	}
}
