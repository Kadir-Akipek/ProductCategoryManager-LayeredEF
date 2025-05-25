using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
	public class EfAdminDal : GenericRepository<Admin>, IAdminDal
	{

	}
}

/*
genel CRUD ve GetById, entity'e özgü olmayan metotlardır
içinde a harfi geçmeyen kullanıcıları listele(sadece bir entity için çalışır,bunlarda entity kullanmalıyız)
*/

