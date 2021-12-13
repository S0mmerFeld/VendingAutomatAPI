using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Automat.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutomatMachine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryId = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaxProductNum = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    CurrentProdNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomatMachine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseSum = table.Column<float>(type: "real", maxLength: 30, nullable: false),
                    Discount = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Sells = table.Column<int>(type: "int", nullable: false),
                    PriceString = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrentQuantity = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    PriceString = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    SellsDateTime = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceMan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SMCardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceMan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceMan_ServiceCard_SMCardId",
                        column: x => x.SMCardId,
                        principalTable: "ServiceCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AutomatMachine",
                columns: new[] { "Id", "Address", "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[,]
                {
                    { 1, "Address1", 1, 1, 1, "Name1" },
                    { 2, "Address2", 2, 2, 2, "Name2" },
                    { 3, "Address3", 3, 3, 3, "Name3" },
                    { 4, "Address4", 4, 4, 4, "Name4" },
                    { 5, "Address5", 5, 5, 5, "Name5" }
                });

            migrationBuilder.InsertData(
                table: "DiscountCard",
                columns: new[] { "Id", "Discount", "PurchaseSum" },
                values: new object[,]
                {
                    { 5, 5, 5f },
                    { 3, 3, 3f },
                    { 4, 4, 4f },
                    { 1, 1, 1f },
                    { 2, 2, 2f }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CurrentQuantity", "Description", "Location", "Name", "Price", "PriceString", "Sells", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 0, "Газ", "Караван", "Вода", 1m, "1.00", 10, "SD" },
                    { 2, 0, "СО2", "Дафи", "Кола", 2m, "2.00", 13, "SD" },
                    { 3, 0, "Бутерброд", "Аве Плаза", "Снек", 3m, "3.00", 30, "SD" },
                    { 4, 0, "Арабика", "АТБ", "Кофе", 4m, "4.00", 20, "SD" },
                    { 5, 0, "Лэйс", "Комфи", "Чипсы", 5m, "5.00", 11, "SD" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCard",
                columns: new[] { "Id", "Discount" },
                values: new object[,]
                {
                    { 5, 5 },
                    { 3, 3 },
                    { 4, 4 },
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ServiceMan",
                columns: new[] { "Id", "Name", "SMCardId", "Surname" },
                values: new object[,]
                {
                    { 1, "Name1", null, "Surname1" },
                    { 2, "Name2", null, "Surname2" },
                    { 3, "Name3", null, "Surname3" },
                    { 4, "Name4", null, "Surname4" },
                    { 5, "Name5", null, "Surname5" }
                });

            migrationBuilder.InsertData(
                table: "Solds",
                columns: new[] { "Id", "Name", "Price", "PriceString", "SellsDateTime", "Tax" },
                values: new object[,]
                {
                    { 16, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 17, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 18, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 19, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 20, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 21, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 25, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 23, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 24, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 26, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 27, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 22, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 15, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 2, "Кола", 2m, "2.00", new DateTime(2021, 11, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 13, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 12, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 11, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m }
                });

            migrationBuilder.InsertData(
                table: "Solds",
                columns: new[] { "Id", "Name", "Price", "PriceString", "SellsDateTime", "Tax" },
                values: new object[,]
                {
                    { 10, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 9, "Чипсы", 5m, "5.00", new DateTime(2021, 11, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 8, "Чипсы", 5m, "5.00", new DateTime(2021, 11, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 7, "Чипсы", 5m, "5.00", new DateTime(2021, 11, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 6, "Чипсы", 5m, "5.00", new DateTime(2021, 11, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 5, "Чипсы", 5m, "5.00", new DateTime(2021, 11, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 4, "Кофе", 4m, "4.00", new DateTime(2021, 11, 4, 7, 40, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 3, "Снек", 3m, "3.00", new DateTime(2021, 11, 3, 7, 30, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 28, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 1, "Вода", 1m, "1.00", new DateTime(2021, 11, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 14, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 29, "Чипсы", 5m, "5.00", new DateTime(2021, 12, 5, 7, 50, 0, 0, DateTimeKind.Unspecified), 20m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomatMachine_Id",
                table: "AutomatMachine",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCard_Id",
                table: "DiscountCard",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Id",
                table: "Product",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCard_Id",
                table: "ServiceCard",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceMan_Id",
                table: "ServiceMan",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceMan_SMCardId",
                table: "ServiceMan",
                column: "SMCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Solds_Id",
                table: "Solds",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutomatMachine");

            migrationBuilder.DropTable(
                name: "DiscountCard");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ServiceMan");

            migrationBuilder.DropTable(
                name: "Solds");

            migrationBuilder.DropTable(
                name: "ServiceCard");
        }
    }
}
