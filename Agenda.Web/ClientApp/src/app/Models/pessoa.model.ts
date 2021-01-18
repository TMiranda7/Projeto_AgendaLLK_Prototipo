import { EnderecoModel } from "./endereco.model";

export interface PessoaModel {
    id?: number;
    nome: string;
    cpf: number;
    endereco: EnderecoModel 
    tipoContato: number;
    telefone: number;
    celular: number;
    email: string;
    site: string;
}