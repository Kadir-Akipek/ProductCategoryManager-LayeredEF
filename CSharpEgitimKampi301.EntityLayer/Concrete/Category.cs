using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
	public class Category
	{
        public int CategoryId { get; set; } //PK olması için --> className+Id
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } //bir kategoride birden fazla ürün olabileceği için List'i kullandık
    }
}
