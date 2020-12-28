import { Endereco } from "./endereco.model";

export interface Pessoa {
    id: number;
    nome: string;
    cpf: number;
    endereco: Endereco;
}

export interface Contatos {
    pessoa : Pessoa
    id: number;
    pesssoaId: number;
    tipoContato: number;
    telefone: number;
    celular: number;
    email: string;
    site: string;
}