import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Contatos } from '../././Models/contatos.model';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls:['./fetch-data.component.css']
})
export class FetchDataComponent {

  public contato: Contatos ;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string , private router : Router , private _contato: Contatos) {
    //this.contato = _contato;
    
  }

  FormContato(){
    this.router.navigate['/contato']  
  }
}