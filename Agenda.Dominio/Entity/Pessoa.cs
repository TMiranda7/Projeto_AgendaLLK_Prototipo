namespace Agenda.Dominio.Entity
{
    public class Pessoa : Entity
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int tipoContato { get; set; }
        public int celular { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string site { get; set; }
        public virtual Endereco endereco { get; set; }
        public int enderecoId { get; set; }
        public override void Validate()
        {

            if (string.IsNullOrEmpty(nome))
            {
                AdicionarCritica(" Informe um nome ");
            }
        }
    }
}
