import { Component, OnInit } from '@angular/core';
import { GemachesService } from '../services/gemaches.service';

@Component({
  selector: 'app-gemaches-list',
  templateUrl: './gemaches-list.component.html',
  styleUrls: ['./gemaches-list.component.css']
})
export class GemachesListComponent implements OnInit {

  gemaches$
  gemachesInHistory$ = []
  searchText:string

  constructor( private gemachesService: GemachesService ) { }

  ngOnInit() {
    this.getGemaches()
   }

  getGemaches() {
    this.gemaches$ = this.gemachesService.getGemaches()
  }

  addToGemachesInHistory( gemach$ ) {
    this.gemachesInHistory$.unshift( gemach$ );
    if( this.gemachesInHistory$.length > 5 ) {
      this.gemachesInHistory$.pop();
    }
    
  }

}
