using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.Entity
{
    public class Contato : Entity  
    {
        public virtual Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public int TipoContato { get; set; }
        public int Celular { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public override void Validate()
        {
            if ( string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Site) || Celular == null || Telefone == null )
            {
                AdicionarCritica("Informe algum contato!");
            }
        }
    }

    
}
