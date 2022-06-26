import { HttpClient } from '@angular/common/http';
import { EventosService } from './services/eventos.service';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { Evento } from './models/Evento';
import { faCoffee } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit, AfterViewInit {

  constructor(private eventosService: EventosService, private http: HttpClient ) { }

  private _filterEvents: string = '';
  public filterEventList: Evento[] = [];
  public eventos: Evento[] = [];
  public showImages: boolean = true;
  public icons = {
    faCoffee: faCoffee
  }

  public get filterEvents(): string{
    return this._filterEvents;
  }
  public set filterEvents(value: string){
    this._filterEvents = value;
    this.filterEventList = this.filterEvents ? this.handleFilterEvents(this._filterEvents) : this.eventos;
  }

  ngOnInit() {}

  ngAfterViewInit(){
    this.eventosService.getAllEventos().subscribe(response => {
      this.eventos = response
      this.filterEventList = this.eventos
    });
  }

  handleImageDisplay(){
    this.showImages = !this.showImages;
  }

  handleFilterEvents(filterBy: string): any{
    filterBy = filterBy.toLowerCase();
    return this.eventos.filter(event => event.tema.toLowerCase().indexOf(filterBy) !== -1);
  }
}
