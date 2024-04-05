using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderStatusType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44c169aa-f3db-4756-9fcf-44c473a844a9", null, "User", "USER" },
                    { "a2935f19-470e-4c33-bd2c-ed2e53e140bb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "Gender", "Languages", "Name", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "ProfilePicture", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "007ace02-81ff-43c1-8793-c4d562a7baba", null, "6beb1e73-c80e-4873-b46c-b9cdde82b725", new DateOnly(2000, 1, 1), "admin@gmail.com", "Male", "English,Italian", "Admin", "Italian", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w==", "default.png", "e476ae8b-d97a-4f51-8794-ace3d3d7740e", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "44c169aa-f3db-4756-9fcf-44c473a844a9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a2935f19-470e-4c33-bd2c-ed2e53e140bb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "007ace02-81ff-43c1-8793-c4d562a7baba");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
        }
    }
}
