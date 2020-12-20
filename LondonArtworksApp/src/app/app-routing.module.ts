import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ArtistDetailsComponent } from './artist-details/artist-details.component';
import { ArtistListComponent } from './artist-list/artist-list.component';

const routes: Routes = [
  {path: 'artistlist', component: ArtistListComponent},
  {path: 'artistcreate', component: ArtistDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
