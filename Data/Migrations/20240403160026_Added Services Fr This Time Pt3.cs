using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServicesFrThisTimePt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_OwnerId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b521c6d5-db32-4368-bee1-a89c37fd36da");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d392d917-2588-4ef3-8164-ecd5dbf45666");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "15ec179c-c730-440e-910a-692a22749e86");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Services",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_OwnerId",
                table: "Services",
                newName: "IX_Services_ProviderId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "350aac03-9fb4-441a-9710-d23774e68477", null, "Admin", "ADMIN" },
                    { "72626dac-4bff-42d3-8a91-321e340df808", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "1cd840ba-b646-4761-b727-1bf0f9397f18", "2bb02470-e626-4f28-8db7-e712606b309a", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "63e82b35-81ce-47c3-9688-0fddd60e3c98", "Admin", "admin" });

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
                keyValue: "350aac03-9fb4-441a-9710-d23774e68477");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "72626dac-4bff-42d3-8a91-321e340df808");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "1cd840ba-b646-4761-b727-1bf0f9397f18");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "Services",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                newName: "IX_Services_OwnerId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b521c6d5-db32-4368-bee1-a89c37fd36da", null, "User", "USER" },
                    { "d392d917-2588-4ef3-8164-ecd5dbf45666", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "15ec179c-c730-440e-910a-692a22749e86", "91736019-ead4-475e-bd53-ea828cf93c99", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "f4143c9d-4a1b-4b05-9de5-5f97b088e6b6", "Admin", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_OwnerId",
                table: "Services",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
