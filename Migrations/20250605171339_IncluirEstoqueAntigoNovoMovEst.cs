using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class IncluirEstoqueAntigoNovoMovEst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EstoqueAnterior",
                table: "MovimentacaoEstoque",
                type: "DECIMAL(15,5)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EstoqueNovo",
                table: "MovimentacaoEstoque",
                type: "DECIMAL(15,5)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstoqueAnterior",
                table: "MovimentacaoEstoque");

            migrationBuilder.DropColumn(
                name: "EstoqueNovo",
                table: "MovimentacaoEstoque");
        }
    }
}
