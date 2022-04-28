using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Mvc.DataAccessLayer.Migrations
{
    public partial class InsertSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 1, "Sportswear", 0, null }
           );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 2, "Nike", 0, 1 }
            );

            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 3, "Under Armour", 1, 1 }
           );

            migrationBuilder.InsertData(
                 table: "Sections",
                 columns: new[] { "Id", "Name", "Order", "ParentId" },
                 values: new object[] { 4, "Adidas", 2, 1 }
             );

            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 5, "Puma", 3, 1 }
           );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 6, "ASICS", 4, 1 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 7, "Mens", 1, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 8, "Fendi", 0, 7 }
            );

            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 9, "Guess", 1, 7 }
           );

            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 10, "Valentino", 2, 7 }
           );

            migrationBuilder.InsertData(
               table: "Sections",
               columns: new[] { "Id", "Name", "Order", "ParentId" },
               values: new object[] { 11, "Dior", 3, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 12, "Versace", 4, 7 }
             );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 13, "Armani", 5, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 14, "Prada", 6, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 15, "Dolce and Gabbana", 7, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 16, "Chanel", 8, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 17, "Gucci", 1, 7 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 18, "Womens", 2, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 19, "Fendi", 0, 18 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 20, "Guess", 1, 18 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 21, "Valentino", 2, 18 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 22, "Dior", 3, 18 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 23, "Versace", 4, 18 }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 24, "Kids", 3, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 25, "Fashion", 4, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 26, "Households", 5, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 27, "Interiors", 6, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 28, "Clothing", 7, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 29, "Bags", 8, null }
            );

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[] { 30, "Shoes", 9, null }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 30; i > 0; i--)
                migrationBuilder.DeleteData(
                    table: "Sections",
                    keyColumn: "Id",
                    keyValue: i
                );
        }
    }
}
