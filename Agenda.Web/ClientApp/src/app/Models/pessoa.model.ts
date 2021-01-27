import { EnderecoModel } from "./endereco.model";

export interface PessoaModel {
    id?: number;
    nome: string;
    cpf: string;
    tipoContato: number;
    telefone: number;
    celular: number;
    email: string;
    site: string;
    enderecoId: number;
    endereco: EnderecoModel;
}