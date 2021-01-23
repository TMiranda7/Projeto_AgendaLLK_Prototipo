using Agenda.Dominio.Enum;

namespace Agenda.Dominio.Entity
{
    public class Endereco : Entity
    {
        public int id { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public virtual Pessoa pessoa { get;set;}
        public int pessoaId { get; set; }
        public EnumTipoEndereco tipoEndereco { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(cep))
            {
                AdicionarCritica("Informe o CEP");
            }
        }
    }
}
