import { Component, OnInit } from '@angular/core';
import { EnderecoModel } from '../Models/endereco.model';
import { PessoaModel } from '../Models/pessoa.model';
import { ContatoService } from '../Services/contato.services';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-contato-component',
    templateUrl:"./contato.component.html",
    styleUrls:['./contato.component.css']
})
export class ContatoComponent  {

    public endereco:EnderecoModel = {
      CEP:'',
      bairro:'',
      cidade:'',
      complemento:'',
      estado:'',
      logradouro:'',
      numero:''
    }

    public pessoa : PessoaModel = {
      nome: '',
      celular: '',
      cpf: '',
      email: '',
      endereco: this.endereco,
      site:'',
      telefone: '',
      tipoContato: '',
    }

  constructor( public service : ContatoService ,private router: Router , public http: HttpClient ) {
    this.pessoa;
  }

  salvar(){
    console.log(this.pessoa)
  }

  cancelar(){
    this.router.navigate(['/lista'])
  }

  searchCep(cep , form){
    if( cep ){
      this.service.ObterCep(cep).subscribe( dado => this.popularDados( dado , form ) )
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

  resetDados(formulario){
  }

}