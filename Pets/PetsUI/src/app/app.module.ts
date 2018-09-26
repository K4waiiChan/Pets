import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppComponent } from './app.component';
import { PetsFormPageComponent } from './pages/pets-form-page/pets-form-page.component';
import {MatToolbarModule} from '@angular/material';


@NgModule({
  declarations: [
    AppComponent,
    PetsFormPageComponent,

  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatToolbarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
