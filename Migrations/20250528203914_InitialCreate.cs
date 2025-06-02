using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
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
                    UtilizarMesmoEnderecoParaEntrega = table.Column<bool>(type: "BIT", nullable: false),
                    EnderecoEntrega = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    BairroEntrega = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CidadeEntrega = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    EstadoEntrega = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    CepEntrega = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
