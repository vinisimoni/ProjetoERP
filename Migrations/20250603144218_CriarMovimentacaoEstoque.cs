using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class CriarMovimentacaoEstoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovimentacaoEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMaterial = table.Column<int>(type: "INT", nullable: false),
                    TipoMovimentacao = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    OrigemMovimentacao = table.Column<int>(type: "INT", nullable: false),
                    IdOrigemMovimentacao = table.Column<int>(type: "INT", nullable: true),
                    Quantidade = table.Column<decimal>(type: "DECIMAL(15,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentacaoEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentacaoEstoque_Materiais_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "Materiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoEstoque_IdMaterial",
                table: "MovimentacaoEstoque",
                column: "IdMaterial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimentacaoEstoque");
        }
    }
}
