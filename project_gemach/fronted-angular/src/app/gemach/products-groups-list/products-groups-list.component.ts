import { Component, OnInit } from '@angular/core';
import { GemachesService } from 'src/app/services/gemaches.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-products-groups-list',
  templateUrl: './products-groups-list.component.html',
  styleUrls: ['./products-groups-list.component.css']
})
export class ProductsGroupsListComponent implements OnInit {

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
