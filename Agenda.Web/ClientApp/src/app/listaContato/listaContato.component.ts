import { Component, OnInit } from '@angular/core';
import { PessoaSeletor } from '../Seletores/pessoa.seletor';
import { EnderecoSeletor } from '../Seletores/endereco.seletor';
import { ContatoService } from '../Services/contato.services';
import { PessoaModel } from '../Models/pessoa.model';

@Component({
  selector: 'app-listaContato',
  templateUrl: 'listaContato.component.html',
  styleUrls: ['listaContato.component.css']
})
export class ListaContatoComponent implements OnInit {

  public pessoas : any[] ;
  public pessoa: PessoaModel ;
  public enderecoSeletor: EnderecoSeletor ;

  constructor(private service : ContatoService ) {
    service.obterTodos().subscribe( res => {
      this.pessoas = res;
    })
  }

  deletar( valor : PessoaModel ){
    console.log(valor)
    var retorno = confirm("Deseja Realmente Deleter este contato?");
    if( retorno == true){
      this.service.deletar( valor ).subscribe( res =>{
        this.pessoa = res
      })
    }
  }

  ngOnInit(): void {
  }
}
