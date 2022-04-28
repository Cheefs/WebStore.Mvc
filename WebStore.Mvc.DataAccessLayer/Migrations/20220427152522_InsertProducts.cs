using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Mvc.DataAccessLayer.Migrations
{
    public partial class InsertProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { 
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    1, "Easy Polo Black Edition", 1025,  "product1.jpg", 0, 2, 1
                }
            );
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    2, "Easy Polo Black Edition", 1025,  "product1.jpg", 1, 2, 1
                }
            );



            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    3, "Easy Polo Black Edition", 1025,  "product3.jpg", 2, 2, 1
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    4, "Easy Polo Black Edition", 1025,  "product4.jpg", 3, 2, 1
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    5, "Easy Polo Black Edition", 1025,  "product5.jpg", 4, 2, 2
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    6, "Easy Polo Black Edition", 1025,  "product6.jpg", 5, 2, 2
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    7, "Easy Polo Black Edition", 1025,  "product7.jpg", 6, 2, 2
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    8, "Easy Polo Black Edition", 1025,  "product8.jpg", 7, 25, 2
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    9, "Easy Polo Black Edition", 1025,  "product9.jpg", 8, 25, 2
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    10, "Easy Polo Black Edition", 1025,  "product10.jpg", 9, 25, 3
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    11, "Easy Polo Black Edition", 1025,  "product11.jpg", 10, 25, 3
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {
                    "Id", "Name", "Price", "ImageUrl", "Order", "SectionId", "BrandId"
                },
                values: new object[] {
                    12, "Easy Polo Black Edition", 1025,  "product12.jpg", 11, 25, 3
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i <= 12; i++)
                migrationBuilder.DeleteData(
                    table: "Products",
                    keyColumn: "Id",
                    keyValue: i
                );
        }
    }
}
