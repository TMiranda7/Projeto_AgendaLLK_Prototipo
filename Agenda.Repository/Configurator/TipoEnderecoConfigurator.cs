using Agenda.Dominio.DataObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Repository.Configurator
{
    class TipoEnderecoConfigurator : IEntityTypeConfiguration<TipoEndereco>
    {
        public void Configure(EntityTypeBuilder<TipoEndereco> builder)
        {
            builder.HasKey(T => T.Id);

            builder.Property(F => F.Descricao)
                   .IsRequired();
        }
    }
}
