using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoERP.Migrations
{
    /// <inheritdoc />
    public partial class AjusteFornecedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Fornecedores",
                type: "VARCHAR(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Fornecedores",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Fornecedores",
                type: "VARCHAR(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Fornecedores",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Fornecedores",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
