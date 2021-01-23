import { ObjectMapper } from 'json-object-mapper';
import { EnderecoSeletor } from "./endereco.seletor";

export class PessoaSeletor {
    public nome : string = '' ;
    public cpf : string = '' ;
    public endereco : EnderecoSeletor ;
    public tipoContato : string = '' ;
    public telefone : string = '' ;
    public celular : string = '' ;
    public email : string = '' ;
    public site : string = '' ;

    create(input : any) : PessoaSeletor {
        return ObjectMapper.deserialize<PessoaSeletor>(PessoaSeletor , input);
    }
}