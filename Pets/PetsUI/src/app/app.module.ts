import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PetsFormPageComponent } from './pages/pets-form-page/pets-form-page.component';


@NgModule({
  declarations: [
    AppComponent,
    PetsFormPageComponent,

  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
