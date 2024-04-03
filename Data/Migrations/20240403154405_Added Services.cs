using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "da4a2611-e66f-4bf4-9f22-057cbaf169fb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dd9d74b6-2647-4bd4-b63f-793bcbbde0a6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "666d59d8-2be7-4fe9-8fbd-6d31ff4cb5e8");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ed9be21-145b-47d3-b948-55420ad18c13", null, "User", "USER" },
                    { "ed1b6318-46de-4449-8eae-cd7409e89724", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "45e16061-5cf1-4c4b-8887-275e35fcd2d6", "e1b91a2e-7189-409b-8e72-6ffddd3c8a65", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "29cac063-d52e-4c4c-8605-d90bc4f71091", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5ed9be21-145b-47d3-b948-55420ad18c13");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ed1b6318-46de-4449-8eae-cd7409e89724");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "45e16061-5cf1-4c4b-8887-275e35fcd2d6");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da4a2611-e66f-4bf4-9f22-057cbaf169fb", null, "Admin", "ADMIN" },
                    { "dd9d74b6-2647-4bd4-b63f-793bcbbde0a6", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "666d59d8-2be7-4fe9-8fbd-6d31ff4cb5e8", "6654e094-a528-4cb2-9e48-bf0d06f6da2c", new DateOnly(2005, 9, 17), "admin@gmail.com", "Male", "Italian,English", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN.ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "c7070b57-7f23-435a-967d-0c880a12c525", "Admin", "admin.admin" });
        }
    }
}
