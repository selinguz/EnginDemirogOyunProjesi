using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class CarRentalContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VST9JT\SQLEXPRESS; Database=CarRental;Trusted_connection=true");
		}

		public DbSet<Car> Car { get; set; }
		public DbSet<Brand> Brand { get; set; }
		public DbSet<Color> Color { get; set; }

	}
}
