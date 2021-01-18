import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ContatoComponent } from './contatosForm/contato.component';
import { FooterComponent } from './footer/footer.component';
import { ListaContatoComponent } from './listaContato/listaContato.component';
import { ContatoService } from './Services/contato.services';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ContatoComponent,
    FooterComponent,
    ListaContatoComponent
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'lista/contato', component: ContatoComponent },
      { path: 'lista', component:ListaContatoComponent}
    ])
  ],
  providers: [ ContatoService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
