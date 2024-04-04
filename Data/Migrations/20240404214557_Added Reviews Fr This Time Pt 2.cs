using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviewsFrThisTimePt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ad18ab1-e28d-4ea6-a126-1790aacd893b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3f76466e-7320-42b1-9906-a24e819f4211");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "4a649760-8c83-45d3-b1e2-27888dbc2c43");

            migrationBuilder.AddColumn<string>(
                name: "IssuerId",
                table: "Reviews",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f197646-ddd0-4830-a4ba-7ca8754e054e", null, "User", "USER" },
                    { "dc7415fd-b7d5-4e54-9a73-471346beaa82", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "66e4a8cb-6004-443c-a911-9ad0b3857eb2", null, "896fbab5-4733-47bd-ba45-a31b74d80361", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "5b0cc6cd-a681-4ff3-b784-76b36ec46d18", "Admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IssuerId",
                table: "Reviews",
                column: "IssuerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_IssuerId",
                table: "Reviews",
                column: "IssuerId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_IssuerId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_IssuerId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7f197646-ddd0-4830-a4ba-7ca8754e054e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dc7415fd-b7d5-4e54-9a73-471346beaa82");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "66e4a8cb-6004-443c-a911-9ad0b3857eb2");

            migrationBuilder.DropColumn(
                name: "IssuerId",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ad18ab1-e28d-4ea6-a126-1790aacd893b", null, "Admin", "ADMIN" },
                    { "3f76466e-7320-42b1-9906-a24e819f4211", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "4a649760-8c83-45d3-b1e2-27888dbc2c43", null, "7535659f-941f-4e29-b37b-2f50c9026341", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "85bd0ece-8384-41af-9aac-00ae49961bb9", "Admin", "admin" });
        }
    }
}
