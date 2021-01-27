import { Component } from '@angular/core';
import { EnderecoModel } from '../Models/endereco.model';
import { PessoaModel } from '../Models/pessoa.model';
import { ContatoService } from '../Services/contato.services';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { EnderecoService } from '../Services/endereco.service';
import { PessoaSeletor } from '../Seletores/pessoa.seletor';

@Component({
    selector: 'app-contato-component',
    templateUrl:"./contato.component.html",
    styleUrls:['./contato.component.css']
})
export class ContatoComponent  {

    public endereco:EnderecoModel = {
      cep:'',
      bairro:'',
      cidade:'',
      complemento:'',
      estado:'',
      logradouro:'',
      numero:''
    }

    public pessoa : PessoaModel = {
      nome: '',
      celular: 0,
      cpf: '',
      email: '',
      site:'',
      telefone: 0,
      tipoContato: 0,
      enderecoId: 0,
      endereco: this.endereco
    }

  constructor( public servicePessoa : ContatoService , public serviceEndereco : EnderecoService ,
               private router: Router , public http: HttpClient ) 
  {
    this.pessoa;
  }

  ngOnInit():void {
    let contatoSession = sessionStorage.getItem('contatoSession')
    //let enderecoSession = sessionStorage.getItem('enderecoSession')
    if(contatoSession){
      this.pessoa = JSON.parse(contatoSession);
      this.endereco = this.pessoa.endereco
    }
  }

  salvar(){
    this.serviceEndereco.salvar(this.endereco).subscribe(resEnd => {
      this.pessoa.enderecoId = resEnd.id
      this.servicePessoa.salvar(this.pessoa).subscribe( resPes => {
      } )
    })
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

  resetDados(formulario){
  }

}