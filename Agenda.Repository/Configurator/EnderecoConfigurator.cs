using Agenda.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Agenda.Repository.Configurator
{
    class EnderecoConfigurator : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .HasKey(E => E.id);
            
            builder
                .Property(E => E.Logradouro)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(E => E.numero)
                .IsRequired();
            
            builder
                .Property(E => E.Complemento)
                .HasMaxLength(100);
            
            builder
                .Property(E => E.Bairro)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(E => E.Cidade)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(E => E.Estado)
                .IsRequired()
                .HasMaxLength(30);
            
            builder
                .Property(E => E.CEP)
                .IsRequired()
                .HasMaxLength(8);
            
            builder
                .Property(E => E.TipoEnderecoId)
                .IsRequired();
            
            builder
                .HasOne(E => E.Pessoa);
        }
    }
}
