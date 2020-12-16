using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMVCBasic.Data.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Fornecedores");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Fornecedores",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Fornecedores");

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Fornecedores",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }
    }
}
