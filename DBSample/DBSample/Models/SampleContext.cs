using DBSample.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSample.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }

        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Fluent APIを使用する場合はここに記載
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
