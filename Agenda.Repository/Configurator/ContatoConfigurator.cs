using Agenda.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Agenda.Repository.Configurator
{
    class ContatoConfigurator : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(C => C.id);
            builder.Property(C => C.Celular);
            builder.Property(C => C.Telefone);
            builder.Property(C => C.Email);
            builder.Property(C => C.Site);
            builder.Property(C => C.PessoaId).IsRequired();
            builder.HasOne(C => C.Pessoa);
        }
    }
}
