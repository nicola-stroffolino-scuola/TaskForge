using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServicesFrThisTimePt7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_AppUserId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1fd53d55-5977-45fb-ab28-5aa310ff6443");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cd71e220-cf8c-45a5-9c02-0315f160943c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "77ea0ad2-1ed9-47a6-ab68-8025b2e362ed");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Services",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_AppUserId",
                table: "Services",
                newName: "IX_Services_ProviderId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c685d61a-ffe1-489d-8e2d-3073dc75e467", null, "Admin", "ADMIN" },
                    { "dbbafd18-4aff-4700-b803-0957dc032385", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "f8ff8863-d6d7-448a-b3dd-7f4b8054ccf1", "9be76841-5ab0-4f9a-b743-2ede81ad88f5", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "4a6626d7-a9f4-491c-aa19-77606ee35509", "Admin", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_ProviderId",
                table: "Services",
                column: "ProviderId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_ProviderId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c685d61a-ffe1-489d-8e2d-3073dc75e467");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dbbafd18-4aff-4700-b803-0957dc032385");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "f8ff8863-d6d7-448a-b3dd-7f4b8054ccf1");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "Services",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                newName: "IX_Services_AppUserId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fd53d55-5977-45fb-ab28-5aa310ff6443", null, "User", "USER" },
                    { "cd71e220-cf8c-45a5-9c02-0315f160943c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "77ea0ad2-1ed9-47a6-ab68-8025b2e362ed", "0c139a98-ddb2-4599-8f58-b291b3b26d10", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "15547b03-899f-43f6-af3d-33fce28c7d47", "Admin", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_AppUserId",
                table: "Services",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
