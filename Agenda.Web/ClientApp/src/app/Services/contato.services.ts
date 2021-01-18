import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';

@Injectable({
    providedIn: 'root'
})

export class ContatoService {

  constructor( private http: HttpClient ){}

  public ObterCep( cep : number){
    let Url = `viacep.com.br/ws/${cep}/json/`;
    return this.http.get(Url);
  }
}