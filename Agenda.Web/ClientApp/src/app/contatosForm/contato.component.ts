import { Component } from '@angular/core';
import { ContatoService } from '../Services/contato.services';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { EnderecoService } from '../Services/endereco.service';
import { PessoaSeletor , EnderecoSeletor } from '../Seletores/contato.seletor';

@Component({
    selector: 'app-contato-component',
    templateUrl:"./contato.component.html",
    styleUrls:['./contato.component.css']
})
export class ContatoComponent  {
   
    public endereco : EnderecoSeletor = new EnderecoSeletor();
    public pessoa : PessoaSeletor = new PessoaSeletor();

  constructor( public servicePessoa : ContatoService, public serviceEndereco : EnderecoService,
               private router: Router , public http: HttpClient ) 
  {
    
    console.log(this.pessoa)
    this.pessoa;

  }

  ngOnInit():void { 
    let contatoSession = sessionStorage.getItem('contatoSession')
    sessionStorage.clear();
    if(contatoSession){
      this.pessoa = JSON.parse(contatoSession);
      this.endereco = this.pessoa.endereco;
      
    }
  }

  salvar(){
    this.serviceEndereco.salvar(this.endereco).subscribe(resEnd => {
      this.pessoa.enderecoId = resEnd.id
      this.servicePessoa.salvar(this.pessoa).subscribe( resPes => {
      } )
    })

    this.router.navigate(['/lista']);
  }

  cancelar(){
    this.router.navigate(['/lista'])
  }

  searchCep(cep , form){
    if( cep ){
      this.serviceEndereco.ObterCep(cep).subscribe( dado => this.popularDados( dado , form ) )
    }
  }

  popularDados( dados, formulario){
    formulario.form.patchValue({
        logradouro : dados.logradouro,
        bairro: dados.bairro ,
        cidade : dados.localidade,
        estado : dados.uf
    });
  }

  cleaner(){
    this.pessoa = new PessoaSeletor();
  }

  resetDados(formulario){
  }

}