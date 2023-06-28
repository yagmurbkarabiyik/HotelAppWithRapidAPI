﻿using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=YAGMUR;database=HotelApiDB;integrated security=true;TrustServerCertificate=true");
		}

		public DbSet<Room> Rooms { get; set; }	
		public DbSet<Service> Services { get; set; }	
		public DbSet<Staff> Staffs { get; set; }	
		public DbSet<Subscribe> Subscribes { get; set; }	
		public DbSet<Testimonial> Testimonials { get; set; }	
		public DbSet<About> Abouts { get; set; }	
		public DbSet<Booking> Bookings { get; set; }	
	}
}