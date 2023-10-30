using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Entities;
using WebNews.Data.Enums;

namespace WebNews.Data.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.content).IsRequired();
            builder.Property(x => x.author_id).IsRequired();
            builder.Property(x => x.category_id).IsRequired();
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
            builder.Property(x => x.Image).IsRequired();
        }
    }
}
