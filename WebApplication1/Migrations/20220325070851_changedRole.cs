using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class changedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f633c84-db89-44b7-b742-87382f620beb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6b92fcd-be65-4af9-95d9-47522591ec4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d64c92d8-cbc6-4b91-bdcc-cf9352625d99", "68f6864b-fe87-4b80-9260-e979f3551b1c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16ec23bf-1311-4a45-a158-bff54d7eaa46", "7fcdc6b6-98da-45a3-a0a9-fd94c2a327a0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ec23bf-1311-4a45-a158-bff54d7eaa46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64c92d8-cbc6-4b91-bdcc-cf9352625d99");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6b92fcd-be65-4af9-95d9-47522591ec4c", "651fd988-f0f9-413c-960d-df420f894711", "Role", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f633c84-db89-44b7-b742-87382f620beb", "0206a7e7-d745-42f0-86e9-86640e468c6c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
