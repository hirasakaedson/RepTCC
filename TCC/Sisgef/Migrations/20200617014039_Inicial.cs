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
                    Tipo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Bandeira = table.Column<string>(type: "varchar(20)", nullable: true),
                    Contato = table.Column<string>(type: "varchar(25)", nullable: true),
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
                    Observacao = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
