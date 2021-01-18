import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listaContato',
  templateUrl: 'listaContato.component.html',
  styleUrls: ['listaContato.component.css']
})
export class ListaContatoComponent implements OnInit {

  public Contatos: any[] = [
    { nome:'Thiago',  email:'thiago@mail.com',  telefone:86868035 },
    { nome:'Miranda', email:'miranda@mail.com', telefone:86868035 },
    { nome:'Souza',   email:'souza@mail.com',   telefone:86868035 }
  ]

  constructor() {
   }

  ngOnInit(): void {
  }
}
