using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.Entity
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int EnderecoId { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                this.AdicionarCritica("Informe o nome!");
            }
        }
    }
}
