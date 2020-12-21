using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Agenda.Repository.Context;

namespace Agenda.Repository.Repository
{
    public class PessoaRepository : BaseRepository<Pessoa> , IPessoaRepository
    {
        public PessoaRepository(AgendaContext agendaContext) : base(agendaContext)
        {
        }
    }
}
