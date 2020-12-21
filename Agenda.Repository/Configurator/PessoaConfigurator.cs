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
            builder.HasKey(P => P.id);
            builder.Property(P => P.Nome).IsRequired();
            builder.Property(P => P.CPF).IsRequired();
            builder.Property(P => P.EnderecoId).IsRequired();
            builder.HasMany(P => P.Endereco).WithOne(E => E.Pessoa);

        }
    }
}
