using Agenda.Dominio.DataObject;
using Agenda.Dominio.Enum;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.Entity
{
    public class Endereco : Entity
    {
        public int id { get; set; }
        public string Logradouro { get; set; }
        public int numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public virtual Pessoa Pessoa { get;set;}
        public virtual TipoEndereco TipoEndereco { get; set; }
        public int TipoEnderecoId { get; set; }

        public override void Validate()
        {
            LimparValidacao();
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Informe o CEP");
            }
        }
    }
}
