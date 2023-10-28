using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Entities;

namespace WebNews.Data.EF
{
    public class WebNewsDbContext : DbContext
    {
        public WebNewsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<News> Newss { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
