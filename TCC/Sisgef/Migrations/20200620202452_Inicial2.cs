using Microsoft.EntityFrameworkCore.Migrations;

namespace Sisgef.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Requisicao_RequisicaoId",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Veiculo_VeiculoId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_RequisicaoId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_VeiculoId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "RequisicaoId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequisicaoId",
                table: "Veiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Veiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Fornecedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_RequisicaoId",
                table: "Veiculo",
                column: "RequisicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_VeiculoId",
                table: "Veiculo",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Requisicao_RequisicaoId",
                table: "Veiculo",
                column: "RequisicaoId",
                principalTable: "Requisicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Veiculo_VeiculoId",
                table: "Veiculo",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
