import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-form-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.css']
})
export class FormInputComponent implements OnInit {
  @Input() placeholder: string;
  @Input() type: string;
  @Input() icon: string;
  @Output() changeValue = new EventEmitter();
  value: string;


  constructor() { }

  ngOnInit() {
  }

  valueChanged() {
    this.changeValue.emit(this.value);
  }
}
