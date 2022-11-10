using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Api.Backend.Migrations
{
    public partial class Deploy1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Instituicaos",
                type: "text",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "Maladiretas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    InstituicaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maladiretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maladiretas_Instituicaos_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maladiretas_InstituicaoId",
                table: "Maladiretas",
                column: "InstituicaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maladiretas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Instituicaos");
        }
    }
}
