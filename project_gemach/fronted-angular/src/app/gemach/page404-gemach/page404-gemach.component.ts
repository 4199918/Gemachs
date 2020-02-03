import { Component, OnInit } from '@angular/core';
import { GemachesService } from 'src/app/services/gemaches.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-page404-gemach',
  templateUrl: './page404-gemach.component.html',
  styleUrls: ['./page404-gemach.component.css']
})
export class Page404GemachComponent implements OnInit {

  gemach$

  constructor(private gemachesService: GemachesService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.getGemach()
  }

  getGemach() {
    let gemachid = this.route.snapshot.paramMap.get('gemachid')
    this.gemach$ = this.gemachesService.getGemach(gemachid)
  }

}
