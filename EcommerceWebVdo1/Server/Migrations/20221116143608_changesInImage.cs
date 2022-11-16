using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceWebVdo1.Server.Migrations
{
    /// <inheritdoc />
    public partial class changesInImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 20, 6, 8, 657, DateTimeKind.Local).AddTicks(9288));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 11, 16, 17, 4, 14, 16, DateTimeKind.Local).AddTicks(3032));
        }
    }
}
