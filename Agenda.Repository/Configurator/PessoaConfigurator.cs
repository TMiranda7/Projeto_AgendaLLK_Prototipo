using Agenda.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Agenda.Repository.Configurator
{
    public class PessoaConfigurator : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .HasKey(P => P.Id);

            builder
                .Property(P => P.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(P => P.CPF)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(P => P.EnderecoId)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(P => P.Endereco)
                .WithOne(P => P.Pessoa)
                .HasForeignKey<Endereco>(P => P.PessoaId);

            builder
                .Property(C => C.Celular)
                .HasMaxLength(10);

            builder
                .Property(C => C.Telefone)
                .HasMaxLength(10);

            builder
                .Property(C => C.Email)
                .HasMaxLength(100);

            builder
                .Property(C => C.Site)
                .HasMaxLength(100);

        }
    }
}
