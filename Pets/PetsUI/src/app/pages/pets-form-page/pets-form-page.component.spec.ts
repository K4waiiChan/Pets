import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PetsFormPageComponent } from './pets-form-page.component';

describe('PetsFormPageComponent', () => {
  let component: PetsFormPageComponent;
  let fixture: ComponentFixture<PetsFormPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PetsFormPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PetsFormPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
