import { EnderecoModel } from "./endereco.model";

export interface PessoaModel {
    id?: number;
    nome: string;
    cpf: string;
    endereco: EnderecoModel 
    tipoContato: string;
    telefone: string;
    celular: string;
    email: string;
    site: string;
}