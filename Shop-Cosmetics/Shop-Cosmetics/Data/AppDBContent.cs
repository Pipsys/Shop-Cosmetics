using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop_Cosmetics.Data.Models;


namespace Shop_Cosmetics.Data
{
	public class AppDBContent : DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{

		}

		public DbSet<Cosmetics> Cosmetics { get; set; }
		public DbSet<Category> Category { get; set; }
	}
}

