using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Mvc.DataAccessLayer.Migrations
{
    public partial class InsertBaseRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "AspNetRoles",
               columns: new[] { "Id", "Name", "NormalizedName" },
               values: new object[] { "1", "admin", "ADMIN" }
           );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { "2", "user", "USER" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "AspNetRoles",
               keyColumn: "Name",
               keyValue: "admin"
            );

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Name",
                keyValue: "user"
            );
        }
    }
}
