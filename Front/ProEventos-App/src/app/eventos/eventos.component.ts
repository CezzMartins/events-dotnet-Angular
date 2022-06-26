import { HttpClient } from '@angular/common/http';
import { EventosService } from './services/eventos.service';
import { Component, OnInit } from '@angular/core';
import { Evento } from './models/Evento';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private eventosService: EventosService, private http: HttpClient ) { }
  eventos: Evento[] = [];
  public urlBase: string = "https://localhost:7104/api/Evento";

  ngOnInit() {
    this.eventosService.getAllEventos().subscribe(response => this.eventos = response);
  }
}
