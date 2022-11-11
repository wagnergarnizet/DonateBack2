using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produtos VALUES (1,'Arroz',50,5,'arroz',1,1);");
            mb.Sql("INSERT INTO produtos VALUES (2,'Feijão',100,1,'feijao',1,1);");
            mb.Sql("INSERT INTO produtos VALUES (3,'Macarrao',100,500,'macarrao',1,1);");
            mb.Sql("INSERT INTO produtos VALUES (4,'Camisa',10,3,'camisa',1,2);");
            mb.Sql("INSERT INTO produtos VALUES (5,'Calca',15,3,'calca',1,2);");
            mb.Sql("INSERT INTO produtos VALUES (6,'Sapato',30,3,'sapato',1,3);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produtos WHERE id > 0;");
        }
    }
}
