﻿using DJAVA.Domain.Customers;
using DJAVA.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJAVA.Domain.Orders
{
	public class Order
	{
		private readonly HashSet<LineItem> _LineItem = new();
		public Guid Id { get; private set; }
		public Guid CustomerId { get; set; }

		public static Order Create(Customer customer)
		{
			var order = new Order
			{
				Id = Guid.NewGuid(),
				CustomerId = customer.Id,
			};

			return order;
		}

		public void Add(Product product)
		{
			var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
		}
	}

	public class LineItem
	{
		internal LineItem(Guid id, Guid orderId, Guid productId, Money price)
		{
			Id = id;
			OrderId = orderId;
			ProductId = productId;
			Price = price;
		}
		public Guid Id { get; set; }
		public Guid OrderId { get; private set; }
		public Guid ProductId { get; private set; }
		public Money Price { get; private set; }
	}
}
