using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Agenda.Repository.Context;

namespace Agenda.Repository.Repository
{
    public class ContatoRepository : BaseRepository<Contato> , IContatoRepositry
    {
        public ContatoRepository(AgendaContext agendaContext) : base (agendaContext)
        {
        }
    }
}
