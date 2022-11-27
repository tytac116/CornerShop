using System;
using CornerShop.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CornerShop
{
	public class AppDataContext : DbContext
	{
		public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}

