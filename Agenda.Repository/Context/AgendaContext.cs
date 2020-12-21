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

        public AgendaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfigurator());
            modelBuilder.ApplyConfiguration(new ContatoConfigurator());
            modelBuilder.ApplyConfiguration(new EnderecoConfigurator());

            base.OnModelCreating(modelBuilder);
        }
    }
}
