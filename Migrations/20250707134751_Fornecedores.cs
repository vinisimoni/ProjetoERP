using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class Fornecedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    TipoPessoa = table.Column<int>(type: "INT", nullable: false),
                    CpfCnpj = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    Cep = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    Situacao = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
