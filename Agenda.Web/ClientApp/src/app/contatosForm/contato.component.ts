import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-contato-component',
    templateUrl:"./contato.component.html",
    styleUrls:['./contato.component.css']
})
export class ContatoComponent {


constructor(private router: Router) {
}
    cancelar(){
        alert("Os campos serão Limpos!");
    }
}