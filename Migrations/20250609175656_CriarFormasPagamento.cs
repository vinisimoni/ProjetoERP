using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class CriarFormasPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormasPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    AVista = table.Column<bool>(type: "bit", nullable: false),
                    MaxParcelas = table.Column<int>(type: "int", nullable: false),
                    TaxaAdministradora = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    DiasRecebimento = table.Column<int>(type: "int", nullable: false),
                    AtualizarVencimentos = table.Column<bool>(type: "bit", nullable: false),
                    IdConta = table.Column<int>(type: "int", nullable: false),
                    PermiteVenda = table.Column<bool>(type: "bit", nullable: false),
                    PermiteRecebimento = table.Column<bool>(type: "bit", nullable: false),
                    PermiteCompra = table.Column<bool>(type: "bit", nullable: false),
                    PermitePagamento = table.Column<bool>(type: "bit", nullable: false),
                    Situacao = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormasPagamento_Contas_IdConta",
                        column: x => x.IdConta,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormasPagamento_IdConta",
                table: "FormasPagamento",
                column: "IdConta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormasPagamento");
        }
    }
}
