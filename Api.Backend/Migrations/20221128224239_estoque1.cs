using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class estoque1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques");

            migrationBuilder.AlterColumn<int>(
                name: "CampanhaId",
                table: "Estoques",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques");

            migrationBuilder.AlterColumn<int>(
                name: "CampanhaId",
                table: "Estoques",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
