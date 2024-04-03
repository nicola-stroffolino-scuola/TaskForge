using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class DoublePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3ac61289-3d43-439e-9d5c-e49c24a84ee4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ce9e70d2-651c-4fba-bd74-012f239a0f7d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "05f005f7-f65d-4102-8f4e-22bc453d80f3");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Services",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85c301eb-4b24-41bb-9e9e-6e8575e4485b", null, "User", "USER" },
                    { "98d1622c-13fd-47fe-9ac1-09890015463f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "02f867eb-593d-4162-a777-8052dc2667c2", null, "2c54a619-b5df-4b08-a9ea-c176e122db5e", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "77d63aa1-1872-48fa-a7aa-141f5c177698", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "85c301eb-4b24-41bb-9e9e-6e8575e4485b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "98d1622c-13fd-47fe-9ac1-09890015463f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "02f867eb-593d-4162-a777-8052dc2667c2");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Services",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ac61289-3d43-439e-9d5c-e49c24a84ee4", null, "User", "USER" },
                    { "ce9e70d2-651c-4fba-bd74-012f239a0f7d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "05f005f7-f65d-4102-8f4e-22bc453d80f3", null, "edbf2c74-189d-4955-8956-7be23c86eefc", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "1d3522a5-1a93-4cbf-aee3-d179ac0581d9", "Admin", "admin" });
        }
    }
}
