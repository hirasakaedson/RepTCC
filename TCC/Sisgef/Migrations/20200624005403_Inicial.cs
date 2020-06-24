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
                    Email = table.Column<string>(type: "varchar(30)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Observacoes = table.Column<string>(type: "varchar(20)", nullable: true),
                    Contato = table.Column<string>(type: "varchar(25)", nullable: true),
                    Contato2 = table.Column<string>(type: "varchar(25)", nullable: true),
                    Rua = table.Column<string>(type: "varchar(30)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(30)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Renavam = table.Column<string>(type: "varchar(13)", nullable: false),
                    NomeDoProprietario = table.Column<string>(type: "varchar(100)", nullable: false),
                    CpfCnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", nullable: false),
                    Chassi = table.Column<string>(type: "varchar(20)", nullable: false),
                    TipoDoVeiculo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Combustivel = table.Column<string>(type: "varchar(15)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(20)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(20)", nullable: false),
                    AnoFabricacao = table.Column<string>(type: "varchar(4)", nullable: false),
                    TipoCarroceria = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(20)", nullable: false),
                    Odometro = table.Column<string>(type: "varchar(7)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    LocalDeEmplacamento = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_Requisicao_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_FornecedorId",
                table: "Requisicao",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_VeiculoId",
                table: "Requisicao",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requisicao");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
