using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedServicesFrThisTimePt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_OwnerId1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_OwnerId1",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "866fae65-b9b0-4d45-822b-86b69786f667");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b218528c-f174-4ca2-8e3b-244a3e3407db");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "56bf0ea4-e14a-480d-bc06-8e161c850748");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Services",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

            migrationBuilder.CreateIndex(
                name: "IX_Services_OwnerId",
                table: "Services",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_OwnerId",
                table: "Services",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_OwnerId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_OwnerId",
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

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Services",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId1",
                table: "Services",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "866fae65-b9b0-4d45-822b-86b69786f667", null, "User", "USER" },
                    { "b218528c-f174-4ca2-8e3b-244a3e3407db", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "56bf0ea4-e14a-480d-bc06-8e161c850748", "264ebeff-9d57-4f2c-8676-25a9b3fbda3a", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "19d709a1-5611-4d57-a83c-7110af4567ac", "Admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Services_OwnerId1",
                table: "Services",
                column: "OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_OwnerId1",
                table: "Services",
                column: "OwnerId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
