using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddSpAlterarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE [dbo].[AlterarAmigo]
                    @id int,
	                @nome nvarchar(max),
	                @sobrenome nvarchar(max),
	                @email nvarchar(max),
	                @telefone nvarchar(max),
	                @dataNascimento datetime2(7)
                AS
                    UPDATE AMIGO SET
                        NOME = @nome,
                        SOBRENOME = @sobrenome,
                        EMAIL = @email,
                        TELEFONE = @telefone,
                        DATANASCIMENTO = @dataNascimento
                    WHERE ID = @id
                RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE [dbo].[AlterarAmigo]
            ");
        }
    }
}
