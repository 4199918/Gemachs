import { Component, OnInit } from '@angular/core';
import { GemachesService } from 'src/app/services/gemaches.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-signup-gemach',
  templateUrl: './signup-gemach.component.html',
  styleUrls: ['./signup-gemach.component.css']
})
export class SignupGemachComponent implements OnInit {

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
