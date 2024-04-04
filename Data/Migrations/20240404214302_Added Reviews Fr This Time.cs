using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviewsFrThisTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Services_ServiceId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_ClientId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c27a28c0-544a-4248-abef-6ee32847a1ff");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "de3ded07-87fe-4ae6-9677-3e51a1384733");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ServiceId",
                table: "Orders",
                newName: "IX_Orders_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ClientId",
                table: "Orders",
                newName: "IX_Orders_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Subject = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Stars = table.Column<double>(type: "REAL", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ServiceId",
                table: "Reviews",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_ClientId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

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

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ServiceId",
                table: "Order",
                newName: "IX_Order_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ClientId",
                table: "Order",
                newName: "IX_Order_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c27a28c0-544a-4248-abef-6ee32847a1ff", null, "Admin", "ADMIN" },
                    { "de3ded07-87fe-4ae6-9677-3e51a1384733", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Services_ServiceId",
                table: "Order",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_ClientId",
                table: "Order",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
