import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm} from '@angular/forms';
import { GemachesService } from '../services/gemaches.service';

@Component({
  selector: 'app-support-center',
  templateUrl: './support-center.component.html',
  styleUrls: ['./support-center.component.css']
})
export class SupportCenterComponent implements OnInit {

  FormData: FormGroup;

  constructor(private builder: FormBuilder, private contact: GemachesService) { }

  ngOnInit() {
    this.FormData = this.builder.group({
      Fullname: new FormControl('', [Validators.required]),
      Email: new FormControl('', [Validators.compose([Validators.required, Validators.email])]),
      Comment: new FormControl('', [Validators.required])
    })
  }

  onSubmit(FormData) {
    console.log(FormData)
    this.contact.postMessage(FormData)
    .subscribe(response => {
      location.href = 'https://mailthis.to/confirm'
      console.log(response)
    }, error => {
      console.warn(error.responseText)
      console.log({ error })
    })
  }
}
