using System.Collections.Generic;
using System.Linq;

namespace Agenda.Dominio.Entity
{
    public abstract class Entity
    {
        public int id { get; set; }
        public abstract void Validate();
        public List<string> _mensagem { get; set; }

        public bool EValido
        {
            get
            {
                return !_mensagem.Any();
            }
        }
        protected List<string> MensagemValidacao
        {
            get
            {
                return _mensagem ?? (_mensagem = new List<string>());
            }
        }
        protected void LimparValidacao()
        {
            _mensagem.Clear();
        }

        public void AdicionarCritica(string msg)
        {
            MensagemValidacao.Add(msg);
        }
    }
}
