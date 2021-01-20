import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { EnderecoModel } from '../Models/endereco.model';

@Injectable({
    providedIn: 'root'
})

export class ContatoService {

  constructor( private http: HttpClient ){}

  public ObterCep( cep : number ):Observable<any>{
    return new Observable<any> ( observer => {
      let Url = `//viacep.com.br/ws/${cep}/json/`;
      this.http.get(Url)
      .pipe(map(res => res)).subscribe( dado => observer.next(dado));
    })
  }

}