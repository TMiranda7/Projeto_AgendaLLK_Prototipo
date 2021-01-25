import { HttpClient, HttpHandler, HttpHeaders } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { EnderecoModel } from '../Models/endereco.model';
import { PessoaModel } from '../Models/pessoa.model';

@Injectable({
    providedIn: 'root'
})

export class ContatoService implements OnInit {

  public Url = 'https://localhost:44371/';
  public pessoas: PessoaModel[];

  constructor( private http: HttpClient ){
  }

  ngOnInit():void{
    this.pessoas = [];
  }

  get header(): HttpHeaders{
    return new HttpHeaders().set('content-type','application/json',)
  }

  public salvar( pessoa : PessoaModel ):Observable<any> {
    return this.http.post(`${this.Url}api/pessoa/` , JSON.stringify(pessoa),{ headers: this.header })
  }

  public deletar( pessoa : PessoaModel ):Observable<any> {
    return this.http.post<PessoaModel[]>(`${this.Url}api/pessoa/delete` , JSON.stringify(pessoa),{ headers: this.header })
  }

  // public obterProduto( PessoaId: number ):Observable<PessoaModel>{
  //   return this.http.get<PessoaModel>(`${this.Url}api/pessoa/obter`)
  // }

  public obterTodos():Observable<PessoaModel[]>{
    return this.http.get<PessoaModel[]>(`${this.Url}api/pessoa`,{ headers: this.header })
  }
}