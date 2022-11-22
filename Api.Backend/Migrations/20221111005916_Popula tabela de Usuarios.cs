using Api.Backend.Domain.Models;
using Api.Backend.Enums;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.Mime.MediaTypeNames;

namespace Api.Backend.Migrations
{
    public partial class PopulatabeladeUsuarios : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO usuarios VALUES(1, 'wagner', 'wagner@teste.com', 123, 1, 1);");
            mb.Sql("INSERT INTO usuarios VALUES(2, 'sara', 'sara@teste.com', 123, 1, 2);");
            mb.Sql("INSERT INTO usuarios VALUES(3, 'bruno', 'bruno@teste.com', 123, 0, 1);");
            mb.Sql("INSERT INTO usuarios VALUES(4, 'matheus', 'matheus@teste.com', 123, 1, 3);");
            mb.Sql("INSERT INTO donatedb.instituicaos (Id,Nome,Cnpj,Endereco,Cep,Cidade,Estado,Bairro,Latitude,Longitude,Logotipo,Ativo,Descricao,Telefone,Celular,UsuarioId,Email) VALUES (1,'instituição','00431092000164','Rua 1','09912020','SP','SP','Centro',0,0,0,1,null,null,null,1,'teste@53.com');");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM usuarios");
        }
    }
}
