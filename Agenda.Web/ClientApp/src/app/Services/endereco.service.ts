import { HttpClient, HttpHandler, HttpHeaders } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { EnderecoModel } from '../Models/endereco.model';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn:"root"
})

export class EnderecoService implements OnInit {
    public Url = 'https://localhost:44371/';
    public endereco: EnderecoModel[];

  constructor( private http: HttpClient ){
  }

  ngOnInit():void{
    this.endereco = [];
  }

  get header(): HttpHeaders{
    return new HttpHeaders().set('content-type','application/json')
  }

  public salvar( endereco : EnderecoModel ):Observable<any> {
    return this.http.post(`${this.Url}api/endereco/` , JSON.stringify(endereco),{ headers: this.header })
  }

  public deletar( endereco : EnderecoModel ):Observable<any> {
    return this.http.post(`${this.Url}api/endereco/delete` , JSON.stringify(endereco),{ headers: this.header })
  }

  public ObterCep( cep : number ):Observable<any>{
    return new Observable<any> ( observer => {
      let UrlCorreios = `//viacep.com.br/ws/${cep}/json/`;
      this.http.get(UrlCorreios)
      .pipe(map(res => res)).subscribe( dado => observer.next(dado));
    })
  }

  public obterEndereco( endereco: number ):Observable<EnderecoModel>{
    return this.http.get<EnderecoModel>(`${this.Url}api/endereco?id=${endereco}`)
  }

  public obterTodos(  id : number ):Observable<EnderecoModel[]>{
    return this.http.get<EnderecoModel[]>(`${this.Url}api/endereco` ,{headers: this.header })
  }
}