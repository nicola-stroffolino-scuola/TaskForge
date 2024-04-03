using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServicesFrThisTimePt5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "88893a0f-3206-4a8a-8787-48492f4759b0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f952d35-72e9-4c83-99ac-1b36a90d5bb2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "64f18aab-48aa-4462-9671-a217c4de83ad");

            migrationBuilder.AddColumn<string>(
                name: "ProviderId1",
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
                name: "IX_Services_ProviderId1",
                table: "Services",
                column: "ProviderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_ProviderId1",
                table: "Services",
                column: "ProviderId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_ProviderId1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ProviderId1",
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
                name: "ProviderId1",
                table: "Services");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88893a0f-3206-4a8a-8787-48492f4759b0", null, "Admin", "ADMIN" },
                    { "9f952d35-72e9-4c83-99ac-1b36a90d5bb2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "64f18aab-48aa-4462-9671-a217c4de83ad", "91e0092e-9fef-4006-b8a6-1a1e17d1a618", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "04610306-c149-4154-bc4f-40b9707bb27f", "Admin", "admin" });
        }
    }
}
