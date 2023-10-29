using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Entities;

namespace WebNews.Data.Configurations
{
    public class NewsInUserConfiguration : IEntityTypeConfiguration<NewsInUser>
    {
        public void Configure(EntityTypeBuilder<NewsInUser> builder)
        {
            builder.HasKey(t => new { t.author_id, t.category_id });

            builder.ToTable("NewsInUser");

            builder.HasOne(t => t.User).WithMany(pc => pc.NewsInUsers)
                .HasForeignKey(pc => pc.category_id);
            builder.HasOne(t => t.News).WithMany(pc => pc.NewsInUsers)
                .HasForeignKey(pc => pc.author_id);


        }

    } 
}
