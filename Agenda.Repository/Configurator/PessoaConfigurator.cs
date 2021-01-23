using Agenda.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Agenda.Repository.Configurator
{
    class PessoaConfigurator : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .HasKey(P => P.id);

            builder
                .Property(P => P.nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(P => P.cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(P => P.enderecoId)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(P => P.endereco)
                .WithOne(P => P.pessoa)
                .HasForeignKey<Endereco>(P => P.pessoaId);

            builder
                .Property(C => C.celular)
                .HasMaxLength(10);

            builder
                .Property(C => C.telefone)
                .HasMaxLength(10);

            builder
                .Property(C => C.email)
                .HasMaxLength(100);

            builder
                .Property(C => C.site)
                .HasMaxLength(100);

        }
    }
}
