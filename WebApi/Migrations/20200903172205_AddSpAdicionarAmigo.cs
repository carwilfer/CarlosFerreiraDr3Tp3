using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddSpAdicionarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE [dbo].[AdicionarAmigo]
	                @nome nvarchar(max),
	                @sobrenome nvarchar(max),
	                @email nvarchar(max),
	                @telefone nvarchar(max),
	                @dataNascimento datetime2(7)
                AS
	                INSERT INTO [dbo].[Amigo] ([Nome], [Sobrenome], [Email], [Telefone], [DataNascimento]) 
	                VALUES (@nome, @sobrenome, @email, @telefone, @dataNascimento)
                RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE [dbo].[AdicionarAmigo]
            ");
        }
    }
}
