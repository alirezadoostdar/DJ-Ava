using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJAVA.Domain.Products
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; private set; } = null!;
        public Money Price{ get; set; }

		public Sku Sku { get; private set; }
    }
}
