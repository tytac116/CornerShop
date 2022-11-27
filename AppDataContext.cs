using System;
using Microsoft.EntityFrameworkCore;

namespace CornerShop
{
	public class AppDataContext : DbContext
	{
		public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
		{
		}
	}
}

