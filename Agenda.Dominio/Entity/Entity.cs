using System.Collections.Generic;
using System.Linq;

namespace Agenda.Dominio.Entity
{
    public abstract class Entity
    {
        public abstract void Validate();
        private List<string> _mensagemValidacao { get; set; }
        public bool EValido
        {
            get
            {
                return !MensagemValidacao.Any();
            }
        }
        protected List<string> MensagemValidacao
        {
            get
            {
                return _mensagemValidacao ?? (_mensagemValidacao = new List<string>());
            }
        }
        protected void LimparValidacao()
        {
            _mensagemValidacao.Clear();
        }
        public void AdicionarCritica(string msg)
        {
            MensagemValidacao.Add(msg);
        }
    }
}
