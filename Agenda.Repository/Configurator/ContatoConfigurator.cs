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
            builder
                .HasKey(C => C.id);
            
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
            
            builder
                .Property(C => C.PessoaId)
                .IsRequired();
        }
    }
}
