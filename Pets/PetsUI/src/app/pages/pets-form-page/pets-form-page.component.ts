import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '../../../../node_modules/@angular/forms';
import { PetsService } from '../../services/pets/pets.service';

@Component({
  selector: 'app-pets-form-page',
  templateUrl: './pets-form-page.component.html',
  styleUrls: ['./pets-form-page.component.css']
})
export class PetsFormPageComponent implements OnInit {
  validators: FormGroup;
  constructor(public petServ: PetsService) {
    this.validators = new FormGroup({
      name: new FormControl('', Validators.required),
      species: new FormControl('', Validators.required),
      race: new FormControl('', Validators.required),
      age: new FormControl('', Validators.required),
      sex: new FormControl('', Validators.required),
      origin: new FormControl('', Validators.required),
      diseases: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required),
    });
   }

  ngOnInit() {
  }

  submit() {
    this.petServ.add(this.validators.value).subscribe();
  }
}
