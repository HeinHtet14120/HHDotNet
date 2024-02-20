using System;
using System.Data.SqlClient;
using DotNet7.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet7.ConsoleApp.EFCoreExamples
{
	public class AppDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost",
                InitialCatalog = "TestDB",
                UserID = "sa",
                Password = "reallyStrongPwd123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString); 
        }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}

