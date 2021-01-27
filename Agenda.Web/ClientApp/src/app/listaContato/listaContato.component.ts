import { Component, OnInit } from '@angular/core';
import { EnderecoSeletor } from '../Seletores/endereco.seletor';
import { ContatoService } from '../Services/contato.services';
import { PessoaModel } from '../Models/pessoa.model';
import { Router } from '@angular/router';
import { EnderecoModel } from '../Models/endereco.model';
import { EnderecoService } from '../Services/endereco.service';

@Component({
  selector: 'app-listaContato',
  templateUrl: 'listaContato.component.html',
  styleUrls: ['listaContato.component.css']
})
export class ListaContatoComponent implements OnInit {

  public pessoas : any[] ;
  public enderecos : any[] ;
  public pessoa: PessoaModel ;
  public endereco : EnderecoModel ;
  public enderecoSeletor: EnderecoSeletor ;

  constructor( private pessoaService : ContatoService, private router: Router ) {
    pessoaService.obterTodos().subscribe( res => {
      this.pessoas = res;
    })    
  }

  alterar( pessoa : PessoaModel ){
  
    sessionStorage.setItem('contatoSession', JSON.stringify(pessoa));
    this.router.navigate(['lista/contato'])
  }

  deletar( valor : PessoaModel ){
    console.log(valor)
    var retorno = confirm("Deseja Realmente Deleter este contato?");
    if( retorno == true){
      this.pessoaService.deletar( valor ).subscribe( res =>{
        this.pessoa = res
      })
    }
  }

  ngOnInit(): void {
  }
}
