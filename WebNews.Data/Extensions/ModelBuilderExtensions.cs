using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Entities;

namespace WebNews.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<News>().HasData(
        new News() {ID=1,  author_id = 1, category_id = 1, content = "Hnay troi co mua", Title = "du bao thoi tiet", DateCreated = DateTime.Now, Status = Enums.Status.Active },
        new News() { ID = 2, author_id = 2, category_id = 2, content = "Xang hon nay tang them 2000d", Title = "Gia xang tang", DateCreated = DateTime.Now, Status = Enums.Status.Active },
        new News() { ID = 3, author_id = 1, category_id = 3, content = "Tong thong My da den va tham Viet Nam vao hom nay", Title = "Tong Thong My tham Viet Nam", DateCreated = DateTime.Now, Status = Enums.Status.Active }
        );

            modelBuilder.Entity<User>().HasData(
                new User() { Id=1, Name="Long", Email="ThanhLong@gmail.com", Role = "Tac Gia", Password="123"},
                new User() { Id = 2, Name = "Minh", Email = "LeMinh@gmail.com", Role = "Tac Gia", Password="456" }
                );

           modelBuilder.Entity<NewsInUser>().HasData(
                new NewsInUser() { author_id=1, category_id=1 }
                );
        }
    }
}
