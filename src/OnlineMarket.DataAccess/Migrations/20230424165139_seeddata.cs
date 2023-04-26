using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMarket.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2023, 4, 24, 16, 51, 38, 882, DateTimeKind.Utc).AddTicks(3054), "A high-end smartphone with 6.7-inch Super Retina XDR display and 5G connectivity.", "Apple iPhone 13 Pro Max", 1099.99m, null },
                    { 2, 5, new DateTime(2023, 4, 24, 16, 51, 38, 882, DateTimeKind.Utc).AddTicks(3059), "A mid-range smartphone with 6.2-inch Dynamic AMOLED display and 5G connectivity.", "Samsung Galaxy S21", 799.99m, null },
                    { 3, 2, new DateTime(2023, 4, 24, 16, 51, 38, 882, DateTimeKind.Utc).AddTicks(3061), "A foldable smartphone with 6.2-inch Flex View OLED display and 5G connectivity.", "Motorola Razr 5G", 1399.99m, null },
                    { 4, 15, new DateTime(2023, 4, 24, 16, 51, 38, 882, DateTimeKind.Utc).AddTicks(3062), "A budget smartphone with 6.5-inch IPS LCD display and 4G connectivity.", "Xiaomi Redmi 10", 179.99m, null },
                    { 5, 7, new DateTime(2023, 4, 24, 16, 51, 38, 882, DateTimeKind.Utc).AddTicks(3064), "A high-end smartphone with 6.7-inch Fluid AMOLED display and 5G connectivity.", "OnePlus 9 Pro", 899.99m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
