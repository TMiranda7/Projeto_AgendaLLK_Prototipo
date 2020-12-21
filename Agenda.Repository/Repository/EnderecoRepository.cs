using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Agenda.Repository.Context;

namespace Agenda.Repository.Repository
{
    public class EnderecoRepository : BaseRepository<Endereco> , IEnderecoRepository
    {
        public EnderecoRepository(AgendaContext agendaContext) : base(agendaContext)
        {
        }
    }
}
