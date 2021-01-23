import { ObjectMapper } from "json-object-mapper";

export class EnderecoSeletor {
    public cep : number = 0 ;
    public logradouro : string = '' ;
    public complemento : string = '' ;
    public numero : number = 0 ;
    public bairro : string = '' ;
    public cidade : string = '' ;
    public estado : string = '' ;

    create(input : any) : EnderecoSeletor {
        return ObjectMapper.deserialize<EnderecoSeletor>( EnderecoSeletor , input );
    } 
}