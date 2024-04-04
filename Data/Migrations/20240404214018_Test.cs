using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Order",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Order",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Order",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c27a28c0-544a-4248-abef-6ee32847a1ff", null, "Admin", "ADMIN" },
                    { "de3ded07-87fe-4ae6-9677-3e51a1384733", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c27a28c0-544a-4248-abef-6ee32847a1ff");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "de3ded07-87fe-4ae6-9677-3e51a1384733");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Order",
                newName: "Timestamp");

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
    }
}
