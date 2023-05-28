using System;
using Microsoft.EntityFrameworkCore;

namespace BucOverflow.Models
{
	public class DataContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlite($"Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "database.db"));
        }
      
        public DbSet<QuestionModel> Questions { get; set; }
		public DbSet<AnswerModel> Answers { get; set; }
	}
}

