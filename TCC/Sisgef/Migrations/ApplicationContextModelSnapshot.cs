﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sisgef;

namespace Sisgef.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sisgef.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Contato2")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Posto")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Sisgef.Models.Requisicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Litros")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Motorista")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TipoDeServico")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Valor")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Requisicao");
                });

            modelBuilder.Entity("Sisgef.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CidadeDeEmplacamento")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Combustivel")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("EstadoEmplacamento")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NomeDoProprietario")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Odometro")
                        .IsRequired()
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Proprio")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasColumnType("varchar(13)");

                    b.Property<string>("TipoCarroceria")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TipoDoVeiculo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Sisgef.Models.Requisicao", b =>
                {
                    b.HasOne("Sisgef.Models.Fornecedor", "Fornecedor")
                        .WithMany("Requisicoes")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sisgef.Models.Veiculo", "Veiculo")
                        .WithMany("Requisicoes")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
