using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class estoque3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Instituicaos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Instituicaos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
