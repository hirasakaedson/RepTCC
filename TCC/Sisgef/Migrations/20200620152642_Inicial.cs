using Microsoft.EntityFrameworkCore.Migrations;

namespace Sisgef.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeServico = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Observacoes = table.Column<string>(type: "varchar(20)", nullable: true),
                    Contato = table.Column<string>(type: "varchar(25)", nullable: true),
                    Contato2 = table.Column<string>(type: "varchar(25)", nullable: true),
                    Rua = table.Column<string>(type: "varchar(30)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(30)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(30)", nullable: true),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Requisicao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "varchar(20)", nullable: false),
                    UsuarioEmissor = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipoDeServico = table.Column<string>(type: "varchar(20)", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Motorista = table.Column<string>(type: "varchar(50)", nullable: true),
                    Valor = table.Column<string>(type: "varchar(50)", nullable: false),
                    VeiculoId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requisicao_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "varchar(20)", nullable: false),
                    Renavam = table.Column<string>(type: "varchar(20)", nullable: true),
                    Marca = table.Column<string>(type: "varchar(25)", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(30)", nullable: true),
                    Cor = table.Column<string>(type: "varchar(20)", nullable: true),
                    Chassi = table.Column<string>(type: "varchar(30)", nullable: true),
                    TipoDoVeiculo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TipoCarroceria = table.Column<string>(type: "varchar(30)", nullable: true),
                    AnoFabricacao = table.Column<string>(type: "varchar(15)", nullable: true),
                    Odometro = table.Column<string>(type: "varchar(20)", nullable: true),
                    Combustivel = table.Column<string>(type: "varchar(20)", nullable: true),
                    NomeDoProprietario = table.Column<string>(type: "varchar(100)", nullable: true),
                    DocumentoDoProprietario = table.Column<string>(type: "varchar(25)", nullable: true),
                    LocalDeEmplacamento = table.Column<string>(type: "varchar(30)", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(50)", nullable: true),
                    RequisicaoId = table.Column<int>(nullable: true),
                    VeiculoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Requisicao_RequisicaoId",
                        column: x => x.RequisicaoId,
                        principalTable: "Requisicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_FornecedorId",
                table: "Requisicao",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_VeiculoId",
                table: "Requisicao",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_RequisicaoId",
                table: "Veiculo",
                column: "RequisicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_VeiculoId",
                table: "Veiculo",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requisicao_Veiculo_VeiculoId",
                table: "Requisicao",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requisicao_Fornecedor_FornecedorId",
                table: "Requisicao");

            migrationBuilder.DropForeignKey(
                name: "FK_Requisicao_Veiculo_VeiculoId",
                table: "Requisicao");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Requisicao");
        }
    }
}
