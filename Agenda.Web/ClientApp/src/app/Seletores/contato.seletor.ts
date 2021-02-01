import { ObjectMapper } from 'json-object-mapper';
import { Seletor } from './baseSeletor';

export class EnderecoSeletor extends Seletor {
    public cep : string = '' ;
    public logradouro : string = '' ;
    public complemento : string = '' ;
    public numero : string = '' ;
    public bairro : string = '' ;
    public cidade : string = '' ;
    public estado : string = '' ;

    Create(input: any) {
        return ObjectMapper.deserialize(EnderecoSeletor, input)
    }
}

export class PessoaSeletor extends Seletor {
    public nome : string = '' ;
    public cpf : string = '' ;
    public endereco = new EnderecoSeletor() ;
    public tipoContato : number = 0 ;
    public telefone : number = 0 ;
    public celular : number = 0;
    public email : string = '' ;
    public site : string = '' ;
    public enderecoId : number = 0 ;

    Create(input: any) {
        return ObjectMapper.deserialize(PessoaSeletor, input)
    }   
}