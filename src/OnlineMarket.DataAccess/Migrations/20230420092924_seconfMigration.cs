using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMarket.DataAccess.Migrations
{
    public partial class seconfMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2023, 4, 20, 9, 29, 24, 564, DateTimeKind.Utc).AddTicks(5911), "A high-end smartphone with 6.7-inch Super Retina XDR display and 5G connectivity.", "Apple iPhone 13 Pro Max", 1099.99m, null },
                    { 2, 5, new DateTime(2023, 4, 20, 9, 29, 24, 564, DateTimeKind.Utc).AddTicks(5915), "A mid-range smartphone with 6.2-inch Dynamic AMOLED display and 5G connectivity.", "Samsung Galaxy S21", 799.99m, null },
                    { 3, 2, new DateTime(2023, 4, 20, 9, 29, 24, 564, DateTimeKind.Utc).AddTicks(5916), "A foldable smartphone with 6.2-inch Flex View OLED display and 5G connectivity.", "Motorola Razr 5G", 1399.99m, null },
                    { 4, 15, new DateTime(2023, 4, 20, 9, 29, 24, 564, DateTimeKind.Utc).AddTicks(5917), "A budget smartphone with 6.5-inch IPS LCD display and 4G connectivity.", "Xiaomi Redmi 10", 179.99m, null },
                    { 5, 7, new DateTime(2023, 4, 20, 9, 29, 24, 564, DateTimeKind.Utc).AddTicks(5918), "A high-end smartphone with 6.7-inch Fluid AMOLED display and 5G connectivity.", "OnePlus 9 Pro", 899.99m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
