using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migros.DAL.Migrations
{
    public partial class init003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_MusteriId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_MusteriId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d34c890-b51f-4aeb-8a70-965d2c58630a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d815d532-45fe-4a49-bc58-ec0e49dab510");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "073901f8-bd50-40e4-bf0f-64dde51e4f8c", "0e2e89fa-34c5-4a57-9216-635595e3b3a2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6db52f22-137c-43dc-83fa-79c0f9cdefbe", "3982b262-032d-4118-9e9e-73b2eaa74527", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserID",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "073901f8-bd50-40e4-bf0f-64dde51e4f8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6db52f22-137c-43dc-83fa-79c0f9cdefbe");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MusteriId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d34c890-b51f-4aeb-8a70-965d2c58630a", "d7b76609-776c-460d-984d-5e2ba0e8f957", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d815d532-45fe-4a49-bc58-ec0e49dab510", "20935a1c-23de-466f-bf85-25f2790cb7d5", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_MusteriId",
                table: "Order",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_MusteriId",
                table: "Order",
                column: "MusteriId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
