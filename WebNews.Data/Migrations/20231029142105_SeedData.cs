using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebNews.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "ID", "DateCreated", "Image", "Status", "Title", "author_id", "category_id", "content" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 29, 21, 21, 5, 453, DateTimeKind.Local).AddTicks(3004), 0, 1, "du bao thoi tiet", 1, 1, "Hnay troi co mua" },
                    { 2, new DateTime(2023, 10, 29, 21, 21, 5, 453, DateTimeKind.Local).AddTicks(3020), 0, 1, "Gia xang tang", 2, 2, "Xang hon nay tang them 2000d" },
                    { 3, new DateTime(2023, 10, 29, 21, 21, 5, 453, DateTimeKind.Local).AddTicks(3021), 0, 1, "Tong Thong My tham Viet Nam", 1, 3, "Tong thong My da den va tham Viet Nam vao hom nay" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "ThanhLong@gmail.com", "Long", "123", "Tac Gia" },
                    { 2, "LeMinh@gmail.com", "Minh", "456", "Tac Gia" }
                });

            migrationBuilder.InsertData(
                table: "NewsInUser",
                columns: new[] { "author_id", "category_id" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewsInUser",
                keyColumns: new[] { "author_id", "category_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
