using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class CampanhaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Campanhas_Campanhas_CampanhaId",
                table: "Produto_Campanhas");

            migrationBuilder.AlterColumn<int>(
                name: "CampanhaId",
                table: "Produto_Campanhas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Campanhas_Campanhas_CampanhaId",
                table: "Produto_Campanhas",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Campanhas_Campanhas_CampanhaId",
                table: "Produto_Campanhas");

            migrationBuilder.AlterColumn<int>(
                name: "CampanhaId",
                table: "Produto_Campanhas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Campanhas_Campanhas_CampanhaId",
                table: "Produto_Campanhas",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
