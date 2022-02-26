using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{  //DbContext'ten kalıtım alıyoruz.
	public class ApplicationDbContext : IdentityDbContext<Users, Role, int>
	{ //Model classları db'ye push edicez gibi düşünebiliriz.
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base
			(options)
		{
		}
		public DbSet<Users> User { get; set; }
		public DbSet<House> House { get; set; }
		public DbSet<UserHouse> UserHouses { get; set; }
		public DbSet<Dues> Dueses { get; set; }
		public DbSet<Bills> Bills { get; set; }
		public DbSet<Message> Messages { get; set; }
        public DbSet<HouseBill> HouseBills { get; set; }
		public DbSet<DuesHouse> DuesHouses { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			SeedUsers(builder);
		//SeedRoles(builder); 
		//SeedHouseType(builder);
		//SeedUserRole(builder);
		//  SeedHouseOwnerType(builder);
			}
		private void SeedUsers(ModelBuilder builder)
		{
			var admin = new Users()
			{
				Id = 1,
				Name = "Oğuzhan",
				SurName = "Kuşcu",
				Email = "oguzk17@gmail.com"

			};

			var user1 = new Users()
			{
				Id = 2,
				Name = "Onur",
				SurName = "Kuşcu",
				Email = "onur@kuscu.com"

			};
			var user2 = new Users()
			{
				Id = 3,
				Name = "Çiğdem",
				SurName = "Kuşcu",
				Email = "cigdem@kuscu.com"

			};
			PasswordHasher<Users> passwordHasher = new PasswordHasher<Users>();
			admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123");
			user1.PasswordHash = passwordHasher.HashPassword(user1, "Abcd123");
			user2.PasswordHash = passwordHasher.HashPassword(user2, "Abcd123");

			builder.Entity<Users>().HasData(admin);
			builder.Entity<Users>().HasData(user1);
			builder.Entity<Users>().HasData(user2);
		}
		private void SeedRoles(ModelBuilder builder)
		{
			builder.Entity<Role>().HasData(
				new Role() { Id = 1, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
				new Role() { Id = 2, Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }

				);
		}
		private void SeedHouseType(ModelBuilder builder)
		{
			builder.Entity<HouseType>().HasData(
				new HouseType() { Id = 1, Type = "1+0" },
				new HouseType() { Id = 2, Type = "1+1" },
				new HouseType() { Id = 3, Type = "2+1" },
				new HouseType() { Id = 4, Type = "3+1" },
				new HouseType() { Id = 5, Type = "4+1" },
				new HouseType() { Id = 6, Type = "5+1" }
				);
		}
		private void SeedUserRole(ModelBuilder builder)
		{
			builder.Entity<UserRole>().HasData(
				new UserRole() { UserId = 1, RoleId = 1 },
				new UserRole() { UserId = 2, RoleId = 2 },
				new UserRole() { UserId = 3, RoleId = 2 },
				new UserRole() { UserId = 4, RoleId = 2 },
				new UserRole() { UserId = 5, RoleId = 2 }

				);
		}
		private void SeedHouseOwnerType(ModelBuilder builder)
		{
			    builder.Entity<HouseOwnerType> ().HasData(
				new HouseOwnerType() { Id = 1, Type = "Owner" },
				new HouseOwnerType() { Id = 2, Type = "Tenant" }

				);
		}
		
		
	}
}
