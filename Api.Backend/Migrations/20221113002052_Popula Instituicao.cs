using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class PopulaInstituicao : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Instituicaos(Id,Nome,Cnpj,Ativo,UsuarioId,Email,latitude,longitude) " +
                "VALUES(1,'ONG A','20.928.889/0001-89',1,2,'ongA@org.com.br',123456789,85488971);");

            mb.Sql("INSERT INTO Instituicaos(Id,Nome,Cnpj,Ativo,UsuarioId,Email,latitude,longitude) " +
                "VALUES(1,'ONG B','81.069.489/0001-50',1,4,'ongB@gmail.com.br',123456789,85488971);");

            mb.Sql("INSERT INTO Instituicaos(Id,Nome,Cnpj,Ativo,UsuarioId,Email,latitude,longitude) " +
                "VALUES(1,'ONG C','16.728.563/0001-30',0,3,'ongC@ong.com.br',123456789,85488971);");

            mb.Sql("INSERT INTO Instituicaos(Id,Nome,Cnpj,Ativo,UsuarioId,Email,latitude,longitude) " +
                "VALUES(1,'ONG D','55.846.210/0001-97',1,1,'ongD@gov.com.br',123456789,85488971);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Instituicaos WHERE ID > 0");
        }
    }
}
