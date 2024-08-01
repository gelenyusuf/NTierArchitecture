﻿using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Project.DAL.ContextClasses
{
	public class MyContext:DbContext
	{
		public MyContext():base("MyConnection")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Configurations.Add(new AppUserMap());
			modelBuilder.Configurations.Add(new ProfileMap());
			modelBuilder.Configurations.Add(new CategoryMap());
			modelBuilder.Configurations.Add(new ProductMap());
			modelBuilder.Configurations.Add(new OrderMap());
			modelBuilder.Configurations.Add(new OrderDetailMap());
	
		}
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserProfile> Profiles { get; set; }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
	}
}
