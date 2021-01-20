using Agenda.Dominio.Enum;

namespace Agenda.Dominio.Entity
{
    public class Endereco : Entity
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public virtual Pessoa Pessoa { get;set;}
        public int PessoaId { get; set; }
        public EnumTipoEndereco TipoEndereco { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Informe o CEP");
            }
        }
    }
}
