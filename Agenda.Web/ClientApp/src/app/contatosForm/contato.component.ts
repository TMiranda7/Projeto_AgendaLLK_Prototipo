import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PessoaSeletor } from '../Seletores/contato.seletor';
import { ContatoService } from '../Services/contato.services';

@Component({
    selector: 'app-contato-component',
    templateUrl:"./contato.component.html",
    styleUrls:['./contato.component.css']
})
export class ContatoComponent  {
    public pessoa : PessoaSeletor;

  constructor( public _pessoa : PessoaSeletor ) {
    this.pessoa = _pessoa;
  }

  cancelar(){
    alert("Os campos serão Limpos!");     
  }

  searchCep(){
    alert("Os pesquisando ");     
  }

}