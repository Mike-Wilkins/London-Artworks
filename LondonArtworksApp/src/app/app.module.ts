import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormControlDirective, FormsModule } from "@angular/forms"
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ArtistDetailsComponent } from './artist-details/artist-details.component';
import { ArtistDetailsFormComponent } from './artist-details/artist-details-form/artist-details-form.component';
import { HttpClientModule } from '@angular/common/http';
import { ArtistListComponent } from './artist-list/artist-list.component';

@NgModule({
  declarations: [
    AppComponent,
    ArtistDetailsComponent,
    ArtistDetailsFormComponent,
    ArtistListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
