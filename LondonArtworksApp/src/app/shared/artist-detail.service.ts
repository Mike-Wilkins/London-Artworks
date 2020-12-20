import { Injectable } from '@angular/core';
import { ArtistDetail } from './artist-detail.model';
import { HttpClient} from '@angular/common/http'


@Injectable({
  providedIn: 'root'
})
export class ArtistDetailService {

  constructor(private http: HttpClient) { }

  formData:ArtistDetail = new ArtistDetail();
  readonly baseURL = 'https://localhost:44337/londonartworks'

  postArtistDetail(){
    return this.http.post(this.baseURL + "/artist/create", this.formData)
  }
}
