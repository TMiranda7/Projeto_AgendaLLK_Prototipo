import { Component, OnInit } from '@angular/core';
import { PessoaSeletor } from '../Seletores/pessoa.seletor';
import { EnderecoSeletor } from '../Seletores/endereco.seletor';
import { ContatoService } from '../Services/contato.services';

@Component({
  selector: 'app-listaContato',
  templateUrl: 'listaContato.component.html',
  styleUrls: ['listaContato.component.css']
})
export class ListaContatoComponent implements OnInit {

  public pessoas : any[] ;
  public pessoaSeletor: PessoaSeletor ;
  public enderecoSeletor: EnderecoSeletor ;
  // public contato = [
  //   { nome:"Thiago" , email:"thigo@mail.com" , celular:986868035 },
  //   { nome:"Miranda" , email:"miranda@mail.com" , celular:986868035 },
  //   { nome:"Souza" , email:"souza@mail.com" , celular:986868035 }
  // ]

  constructor(private service : ContatoService ) {
    service.obterTodos().subscribe( res => {
      this.pessoas = res;
    })
  }

  ngOnInit(): void {
  }
}
