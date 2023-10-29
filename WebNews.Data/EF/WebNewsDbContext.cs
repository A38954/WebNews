using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Configurations;
using WebNews.Data.Entities;
using WebNews.Data.Extensions;
namespace WebNews.Data.EF
{
    public class WebNewsDbContext : DbContext
    {
        public WebNewsDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new NewsInUserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsConfiguration());
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
           

        }
        public DbSet<News> Newss { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
