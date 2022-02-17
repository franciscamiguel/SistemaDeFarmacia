﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeFarmacia.Data;

namespace SistemaDeFarmacia.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210910025034_Pessoa")]
    partial class Pessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaDeFarmacia.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("CPF");

                    b.Property<string>("Cidade");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.Property<string>("TipoPessoa");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Preço");

                    b.Property<string>("Produto");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Desconto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avista");

                    b.Property<string>("SubTotal");

                    b.Property<double>("TotalParcial");

                    b.Property<double>("valor");

                    b.HasKey("Id");

                    b.ToTable("Descontos");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Devolucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CódigoProduto");

                    b.Property<string>("DescriçãoDProduto");

                    b.Property<string>("Prazo");

                    b.Property<string>("Quantidade");

                    b.Property<string>("Unidade");

                    b.Property<string>("ValorTotal");

                    b.Property<string>("ValorUnitario");

                    b.HasKey("Id");

                    b.ToTable("Devolucaos");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<string>("CustoTotal");

                    b.Property<string>("Preço");

                    b.Property<string>("Produto");

                    b.Property<string>("Unidade");

                    b.Property<string>("Venda");

                    b.HasKey("Id");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataValidade");

                    b.Property<string>("NomeProduto");

                    b.Property<string>("Registro");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conhecimentos");

                    b.Property<string>("Conquistas");

                    b.Property<string>("Habilidades");

                    b.Property<string>("Programador");

                    b.HasKey("Id");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("SistemaDeFarmacia.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CEP");

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
