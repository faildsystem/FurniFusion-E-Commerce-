using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurniFusion_E_Commerce_.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647bb4eb-87db-49b6-93f6-46e937a7561e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5e146aa-65d2-4d90-a925-38956fb7f2b8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24ce08fa-d8f7-409c-89e5-ce740181215a", null, "productManager", "PRODUCTMANAGER" },
                    { "425c3d5d-dd18-4062-86d2-c73221227865", null, "moderator", "MODERATOR" },
                    { "9874cba9-0384-4ef6-bd2b-0b3f6ec83220", null, "superAdmin", "SUPERADMIN" },
                    { "b06d831b-8eae-42c4-b144-ad0ba8c62133", null, "marketingManager", "MARKETINGMANAGER" },
                    { "b1b61888-5a80-41c5-8d72-6eb01f2a1d56", null, "user", "USER" },
                    { "c7567b44-2744-49aa-a609-976f74658a30", null, "contentCreator", "CONTENTCREATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24ce08fa-d8f7-409c-89e5-ce740181215a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425c3d5d-dd18-4062-86d2-c73221227865");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9874cba9-0384-4ef6-bd2b-0b3f6ec83220");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b06d831b-8eae-42c4-b144-ad0ba8c62133");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1b61888-5a80-41c5-8d72-6eb01f2a1d56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7567b44-2744-49aa-a609-976f74658a30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "647bb4eb-87db-49b6-93f6-46e937a7561e", null, "admin", "ADMIN" },
                    { "b5e146aa-65d2-4d90-a925-38956fb7f2b8", null, "user", "USER" }
                });
        }
    }
}
