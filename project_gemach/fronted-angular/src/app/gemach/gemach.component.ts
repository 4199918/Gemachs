import { Component, OnInit } from '@angular/core';
import { GemachesService } from '../services/gemaches.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-gemach',
  templateUrl: './gemach.component.html',
  styleUrls: ['./gemach.component.css']
})
export class GemachComponent implements OnInit {

  gemach$

  constructor(private gemachesService: GemachesService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.getGemach()
  }

  getGemach() {
    let gemachid = this.route.snapshot.paramMap.get('gemachid')
    this.gemach$ = this.gemachesService.getGemach(gemachid)
    console.log(`the gemach is: ${this.gemach$.gemachName}`)
  }

}
