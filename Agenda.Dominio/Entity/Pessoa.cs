namespace Agenda.Dominio.Entity
{
    public class Pessoa : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int TipoContato { get; set; }
        public int Celular { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Site))
            {
                AdicionarCritica("Informe algum contato!");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                this.AdicionarCritica("Informe o nome!");
            }
        }

    }
}
