using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class CampoSituacaoNoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Clientes",
                type: "VARCHAR(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Clientes");
        }
    }
}
