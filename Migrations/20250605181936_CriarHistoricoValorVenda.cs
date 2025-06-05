using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class CriarHistoricoValorVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoValorVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMaterial = table.Column<int>(type: "INT", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    ValorAnterior = table.Column<decimal>(type: "DECIMAL(15,2)", nullable: false),
                    ValorNovo = table.Column<decimal>(type: "DECIMAL(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoValorVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoValorVenda_Materiais_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "Materiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoValorVenda_IdMaterial",
                table: "HistoricoValorVenda",
                column: "IdMaterial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoValorVenda");
        }
    }
}
