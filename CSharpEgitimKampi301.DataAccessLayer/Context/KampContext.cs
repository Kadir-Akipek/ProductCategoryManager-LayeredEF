using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
	public class KampContext : DbContext //veri tabanına yansıyacak olan bütün sınıflarımız burada yer alacak
	{
        public DbSet<Category> Categories { get; set; } //Categories SQL'e yansıyacak olan tablo adımız
		public DbSet<Order> Orders { get; set; } //yalın hal class adı çoğul ad SQL'deki tablo adı olur yani
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
