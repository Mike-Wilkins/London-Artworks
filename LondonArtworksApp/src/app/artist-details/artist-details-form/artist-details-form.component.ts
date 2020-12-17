import { Component, OnInit } from '@angular/core';
import { ArtistDetailService } from 'src/app/shared/artist-detail.service';

@Component({
  selector: 'app-artist-details-form',
  templateUrl: './artist-details-form.component.html',
  styles: [
  ]
})
export class ArtistDetailsFormComponent implements OnInit {

  constructor(public service: ArtistDetailService) { }

  ngOnInit(): void {
  }

}
