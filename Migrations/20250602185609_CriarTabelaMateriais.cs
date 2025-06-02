using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaMateriais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Referencia = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    Unidade = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    Situacao = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    ControleEstoque = table.Column<bool>(type: "BIT", nullable: false),
                    EstoqueAtual = table.Column<decimal>(type: "DECIMAL(15,5)", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "DECIMAL(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiais", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materiais");
        }
    }
}
