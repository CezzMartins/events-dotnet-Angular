import { HttpClient } from '@angular/common/http';
import { EventosService } from './services/eventos.service';
import { Component, OnInit } from '@angular/core';
import { Evento } from './models/Evento';
import { faCoffee } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private eventosService: EventosService, private http: HttpClient ) { }
  public eventos: Evento[] = [];
  public icons = {
    faCoffee: faCoffee
  }

  ngOnInit() {
    this.eventosService.getAllEventos().subscribe(response => this.eventos = response);
  }
}
