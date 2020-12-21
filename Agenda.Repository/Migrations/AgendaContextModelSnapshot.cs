﻿// <auto-generated />
using System;
using Agenda.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agenda.Repository.Migrations
{
    [DbContext(typeof(AgendaContext))]
    partial class AgendaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agenda.Dominio.DataObject.TipoEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoEnderecos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Residencial"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Comercial"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Galpão"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Buffet"
                        });
                });

            modelBuilder.Entity("Agenda.Dominio.Entity.Contato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Celular")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Site")
                        .HasMaxLength(100);

                    b.Property<int>("Telefone")
                        .HasMaxLength(10);

                    b.Property<int>("TipoContato");

                    b.HasKey("id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Agenda.Dominio.Entity.Endereco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Complemento")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Pessoaid");

                    b.Property<int>("TipoEnderecoId");

                    b.Property<int>("numero");

                    b.HasKey("id");

                    b.HasIndex("Pessoaid");

                    b.HasIndex("TipoEnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Agenda.Dominio.Entity.Pessoa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("ContatoId");

                    b.Property<int>("EnderecoId")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Agenda.Dominio.Entity.Contato", b =>
                {
                    b.HasOne("Agenda.Dominio.Entity.Pessoa", "Pessoa")
                        .WithMany("Contato")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agenda.Dominio.Entity.Endereco", b =>
                {
                    b.HasOne("Agenda.Dominio.Entity.Pessoa", "Pessoa")
                        .WithMany("Endereco")
                        .HasForeignKey("Pessoaid");

                    b.HasOne("Agenda.Dominio.DataObject.TipoEndereco", "TipoEndereco")
                        .WithMany()
                        .HasForeignKey("TipoEnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
