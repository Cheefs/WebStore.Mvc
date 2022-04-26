using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Mvc.DataAccessLayer.Migrations
{
    public partial class InsertBrands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[] { 1, "Acne", 0 }
            );

            migrationBuilder.InsertData(
               table: "Brands",
               columns: new[] { "Id", "Name", "Order" },
               values: new object[] { 2, "Grüne Erde", 1 }
           );

            migrationBuilder.InsertData(
                 table: "Brands",
                 columns: new[] { "Id", "Name", "Order" },
                 values: new object[] { 3, "Albiro", 2 }
             );

            migrationBuilder.InsertData(
               table: "Brands",
               columns: new[] { "Id", "Name", "Order" },
               values: new object[] { 4, "Ronhill", 3 }
           );

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[] { 5, "Oddmolly", 4 }
            );

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[] { 6, "Boudestijn", 5 }
            );

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[] { 7, "Rösch creative culture", 6 }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i <= 7; i++)
                migrationBuilder.DeleteData(
                    table: "Brands",
                    keyColumn: "Id",
                    keyValue: i
                );

        }
    }
}
