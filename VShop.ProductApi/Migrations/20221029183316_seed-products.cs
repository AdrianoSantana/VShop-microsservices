using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    public partial class seedproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into Products(name, price, description, stock, imageURL, categoryId)" +
                "values('Caderno', 7.42, 'Caderno tilibra', 10, 'caderno1.jpg', 1);"
            );

            migrationBuilder.Sql(
                "insert into Products(name, price, description, stock, imageURL, categoryId)" +
                "values('Caneta', 3.20, 'Caneta azul', 40, 'caneta.jpg', 1);"
            );

            migrationBuilder.Sql(
                "insert into Products(name, price, description, stock, imageURL, categoryId)" +
                "values('Clips', 13.13, 'Clips de aço', 5, 'clips.jpg', 2);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
