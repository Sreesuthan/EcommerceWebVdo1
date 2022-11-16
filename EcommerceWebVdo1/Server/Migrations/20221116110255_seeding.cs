using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceWebVdo1.Server.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "aperture", "Video Games", "video-games" },
                    { 2, "camera-slr", "Movies", "movies" },
                    { 3, "book", "Novels", "novels" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1433), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a PC game. Developed by Ubisoft", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Far_Cry_3_PAL_box_art.jpg/220px-Far_Cry_3_PAL_box_art.jpg", false, false, 1999.99m, 499.99m, "Farcry 3" },
                    { 2, 1, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a PC game. Developed by Ubisoft", "https://upload.wikimedia.org/wikipedia/en/thumb/2/29/Assassin%27s_Creed_III_Game_Cover.jpg/220px-Assassin%27s_Creed_III_Game_Cover.jpg", false, false, 1799.99m, 399.99m, "Assasins Creed 3" },
                    { 3, 1, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a PC game. Developed by Rockstar Games", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png", false, false, 1899.99m, 459.99m, "GTA 5" },
                    { 4, 1, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a PC game. It is a story of Laura Craft", "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/TombRaider2013.jpg/220px-TombRaider2013.jpg", false, false, 1999.99m, 499.99m, "Tomb Raider 2013" },
                    { 5, 2, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a Hollywood Movie in MCU", "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg", false, false, 999.99m, 299.99m, "Avengers EndGame" },
                    { 6, 2, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1496), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a Hollywood Movie in DCU", "https://upload.wikimedia.org/wikipedia/en/6/6b/Justice_League_%28film%29_poster.jpg", false, false, 899.99m, 249.99m, "Justice League" },
                    { 7, 3, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is noval written by KALKI", "https://upload.wikimedia.org/wikipedia/en/b/ba/Ponniyin_selvan_volume_1.jpg", false, false, 1499.99m, 399.99m, "Ponniyin Selvan" },
                    { 8, 3, new DateTime(2022, 11, 16, 16, 32, 54, 998, DateTimeKind.Local).AddTicks(1502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a history play and tragedy by William Shakespeare", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg/220px-Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg", false, false, 1399.99m, 349.99m, "Julius Caeser" }
                });
        }

        /// <inheritdoc />
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
