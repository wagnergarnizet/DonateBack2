using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO categorias VALUES(1,'Não Perecíveis')");
            mb.Sql("INSERT INTO categorias VALUES(2,'Roupas')");
            mb.Sql("INSERT INTO categorias VALUES(3,'Sapatos')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categorias WHERE id > 0");
        }
    }
}
