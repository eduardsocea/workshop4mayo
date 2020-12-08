using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WorkshopDemoApp.Infrastructure.Persistence
{
    public class WorkshopDbContext : DbContext
    {
        public DbSet<Form> Form { get; set; }

        public WorkshopDbContext()
        {
        }
        
        public WorkshopDbContext(DbContextOptions<WorkshopDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(GetConnectionString())
                .UseLoggerFactory(CreateLoggerFactory())
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>(b =>
            {
                b.ToTable("Form");
                b.HasKey(x => x.Id);
                b.Property(x => x.Data)
                    .IsRequired();
            });
        }
        
        private static ILoggerFactory CreateLoggerFactory()
        {
            return LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
                    .AddConsole();
            });
        }

        private string GetConnectionString()
        {
            var connectionString = "Server=[SqlServer];Database=Workshop4Mayo;User Id=[SqlServerUsername];Password=[SqlServerPassword];";
            connectionString = ReplaceFields(connectionString);
            return connectionString;
        }

        private static string ReplaceFields(string value)
        {
            return Regex.Replace(value, @"\[.+?\]", match =>
            {
                string field = match.Value;
                field = field[1..^1];
                return Environment.GetEnvironmentVariable(field);
            });
        }
    }
}