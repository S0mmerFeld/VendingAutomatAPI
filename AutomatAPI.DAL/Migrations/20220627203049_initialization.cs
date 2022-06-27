using Microsoft.EntityFrameworkCore.Migrations;

namespace Automat.DAL.Migrations
{
    public partial class initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 30, 10000001, 100, "Автомат воды" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 44, 10000002, 56, "Автомат снеков" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 33, 10000003, 60, "Автомат сувениров" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 10000004, 10, "Автомат пива" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 11, 10000005, 20, "Автомат пива" });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 6, 1560f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 10, 20000f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 8, 10000f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 7, 5005f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 3, 100f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 10m, "Бонаква" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 20m, "2 литра" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 35m, "Бутерброд" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 40m, "100г Якобс" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShortDescription",
                value: "lays сыр");

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Олег", "Евсеенко" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Никита", "Лебедев" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Андрей", "Воронин" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Павел", "Никифоров" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Сергей", "Иванчук" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 1, 1, 1, "Name1" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 2, 2, 2, "Name2" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 3, 3, 3, "Name3" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 4, 4, "Name4" });

            migrationBuilder.UpdateData(
                table: "AutomatMachine",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentProdNumber", "InventoryId", "MaxProductNum", "Name" },
                values: new object[] { 5, 5, 5, "Name5" });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 1, 1f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 2, 2f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 3, 3f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 4, 4f });

            migrationBuilder.UpdateData(
                table: "DiscountCard",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Discount", "PurchaseSum" },
                values: new object[] { 5, 5f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 1m, "SD" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 2m, "SD" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 3m, "SD" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 4m, "SD" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShortDescription",
                value: "SD");

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Name1", "Surname1" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Name2", "Surname2" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Name3", "Surname3" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Name4", "Surname4" });

            migrationBuilder.UpdateData(
                table: "ServiceMan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Name5", "Surname5" });
        }
    }
}
