using Agenda.Dominio.DataObject;
using Agenda.Dominio.Entity;
using Agenda.Repository.Configurator;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Repository.Context
{
    public class AgendaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<TipoEndereco> TipoEnderecos { get; set; }

        public AgendaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfigurator());
            modelBuilder.ApplyConfiguration(new ContatoConfigurator());
            modelBuilder.ApplyConfiguration(new EnderecoConfigurator());
            modelBuilder.ApplyConfiguration(new TipoEnderecoConfigurator());

            modelBuilder.Entity<TipoEndereco>().HasData(
                new TipoEndereco() { Id = 1 , Descricao = "Residencial" },
                new TipoEndereco() { Id = 2 , Descricao = "Comercial"},
                new TipoEndereco() { Id = 3 , Descricao = "Galpão" },
                new TipoEndereco() { Id = 4 , Descricao = "Buffet" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
