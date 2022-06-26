import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestranteComponent } from './palestrante/palestrante.component';
import { EventosService } from './eventos/services/eventos.service';

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
    PalestranteComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [ EventosService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
