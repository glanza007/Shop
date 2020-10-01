﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Shop.Web.Data
{

	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		private readonly DataContext context;

		public ProductRepository(DataContext context) : base(context)
		{
			this.context = context;
		}

		public IQueryable GetAllWithUsers()
		{
			return this.context.Products.Include(p => p.User).OrderBy(p => p.Name);
		}
	}

}
