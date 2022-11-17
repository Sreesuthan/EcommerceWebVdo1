using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceWebVdo1.Server.Migrations
{
    /// <inheritdoc />
    public partial class productVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionProduct");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Xbox");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Play Station");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "E-book");

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Audio book" });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 2, 1, 1999.99m, 499.99m },
                    { 4, 1, 2499.99m, 599.99m },
                    { 2, 2, 1699.99m, 449.99m },
                    { 3, 2, 1799.99m, 449.99m },
                    { 4, 2, 2299.99m, 519.99m },
                    { 2, 3, 1899.99m, 499.99m },
                    { 3, 4, 1399.99m, 399.99m },
                    { 4, 4, 2199.99m, 499.99m },
                    { 1, 5, 899.99m, 199.99m },
                    { 1, 6, 799.99m, 149.99m },
                    { 5, 7, 999.99m, 249.99m },
                    { 5, 8, 1199.99m, 299.99m },
                    { 6, 7, 1399.99m, 349.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "EditionProduct",
                columns: table => new
                {
                    EditionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionProduct", x => new { x.EditionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_EditionProduct_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditionProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 7 }
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Xbox");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Play Station");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "E-book");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Audio book");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1999.99m, 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1799.99m, 399.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1899.99m, 459.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1999.99m, 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 999.99m, 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 899.99m, 249.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1499.99m, 399.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1399.99m, 349.99m });

            migrationBuilder.CreateIndex(
                name: "IX_EditionProduct_ProductsId",
                table: "EditionProduct",
                column: "ProductsId");
        }
    }
}
