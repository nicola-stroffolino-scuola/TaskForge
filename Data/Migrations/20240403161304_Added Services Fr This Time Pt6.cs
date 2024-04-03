using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServicesFrThisTimePt6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_ProviderId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_ProviderId1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ProviderId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5b04af84-fa87-4e7c-b87b-87d75176d1ba");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c27e2f68-fb70-448e-a415-6eca7c6b47be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "f191fd6c-1de3-4483-9f3e-ee8d4c8d9a9c");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "ProviderId1",
                table: "Services",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ProviderId1",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "ProviderId1");

            migrationBuilder.RenameIndex(
                name: "IX_Services_AppUserId",
                table: "Services",
                newName: "IX_Services_ProviderId1");

            migrationBuilder.AddColumn<string>(
                name: "ProviderId",
                table: "Services",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b04af84-fa87-4e7c-b87b-87d75176d1ba", null, "User", "USER" },
                    { "c27e2f68-fb70-448e-a415-6eca7c6b47be", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "f191fd6c-1de3-4483-9f3e-ee8d4c8d9a9c", "9d54d9b9-c3b4-4865-a1e9-4a91858df193", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "798613ef-ba86-4c1a-87f6-3a966fc177e5", "Admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_ProviderId",
                table: "Services",
                column: "ProviderId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_ProviderId1",
                table: "Services",
                column: "ProviderId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
