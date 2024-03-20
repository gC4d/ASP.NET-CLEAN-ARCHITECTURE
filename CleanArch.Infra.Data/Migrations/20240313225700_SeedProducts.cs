using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArch.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES('Caneta azul', 'Caneta esferográfica azul', 1.99, 100, 'caneta_azul.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES('Caderno quadriculado', 'Caderno quadriculado 200 folhas', 8.99, 75, 'caderno_quadriculado.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES('Lápis HB', 'Lápis grafite HB', 0.49, 200, 'lapis_hb.jpg', 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
