import { Injectable } from '@angular/core';
import { ArtistDetail } from './artist-detail.model';
import { HttpClient} from '@angular/common/http'


@Injectable({
  providedIn: 'root'
})
export class ArtistDetailService {

  constructor() { }

  formData:ArtistDetail = new ArtistDetail();
}
