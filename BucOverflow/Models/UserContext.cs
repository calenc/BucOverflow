using System;
using Microsoft.EntityFrameworkCore;
/*
 * Context model following the same implementation of the Q&A database context (DataContext).
 */
namespace BucOverflow.Models
{
	public class UserContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "users.db"));
        }

        public DbSet<UserModel> Users { get; set; }
    }
}

