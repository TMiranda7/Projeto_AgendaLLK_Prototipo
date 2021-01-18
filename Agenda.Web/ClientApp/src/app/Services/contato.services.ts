import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})

export class ContatoService {

  constructor( private http: HttpClient ){}

  public ObterCep( cep : number){
    if ( cep ){
      let Url = `//viacep.com.br/ws/${cep}/json/`;
      this.http.get(Url).pipe(map(res => res))
      .subscribe( dado => dado);
    }
  }
}