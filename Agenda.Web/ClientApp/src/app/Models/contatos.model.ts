export class Contatos {
    pessoa : Pessoa
    id: number;
    pesssoaId: number;
    tipoContato: number;
    telefone: number;
    celular: number;
    email: string;
    site: string;
}

export class Pessoa {
    id: number;
    nome: string;
    cpf: number
}