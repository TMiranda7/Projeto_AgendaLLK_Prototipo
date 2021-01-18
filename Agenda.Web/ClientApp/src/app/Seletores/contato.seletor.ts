import { ObjectMapper } from 'json-object-mapper';
import { EnderecoSeletor } from "./endereco.seletor";

export class PessoaSeletor {
    public Id : number ;
    public nome : string = '' ;
    public cpf : number = 0 ;
    public endereco : EnderecoSeletor ;
    public tipoContato : number = 0 ;
    public telefone : number = 0 ;
    public celular : number = 0 ;
    public email : string = '' ;
    public site : string = '' ;

    create(input : any) : PessoaSeletor {
        return ObjectMapper.deserialize<PessoaSeletor>(PessoaSeletor , input);
    }
}