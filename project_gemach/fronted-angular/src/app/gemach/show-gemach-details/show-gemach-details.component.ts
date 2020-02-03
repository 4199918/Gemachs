import { Component, OnInit } from '@angular/core';
import { GemachesService } from 'src/app/services/gemaches.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-show-gemach-details',
  templateUrl: './show-gemach-details.component.html',
  styleUrls: ['./show-gemach-details.component.css']
})
export class ShowGemachDetailsComponent implements OnInit {

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
