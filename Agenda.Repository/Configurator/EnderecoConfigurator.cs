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
                .Property(E => E.logradouro)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(E => E.numero)
                .IsRequired()
                .HasMaxLength(4);
            
            builder
                .Property(E => E.complemento)
                .HasMaxLength(100);
            
            builder
                .Property(E => E.bairro)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(E => E.cidade)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(E => E.estado)
                .IsRequired()
                .HasMaxLength(30);
            
            builder
                .Property(E => E.cep)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(E => E.tipoEndereco)
                .IsRequired();
        }
    }
}
