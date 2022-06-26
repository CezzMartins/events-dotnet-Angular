import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Evento } from '../models/Evento';
import { Subscription } from 'rxjs';
@Injectable()
export class EventosService {


  constructor(private http: HttpClient) { }


  public urlBase = "https://localhost:7104/api/Evento";



  public getAllEventos(){
    return this.http.get<Evento[]>(this.urlBase)
  }


}
