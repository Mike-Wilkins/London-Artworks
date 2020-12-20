import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ArtistDetail } from 'src/app/shared/artist-detail.model';
import { ArtistDetailService } from 'src/app/shared/artist-detail.service';

@Component({
  selector: 'app-artist-details-form',
  templateUrl: './artist-details-form.component.html',
  styles: [
  ]
})
export class ArtistDetailsFormComponent implements OnInit {

  constructor(public service: ArtistDetailService,
    private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    this.service.postArtistDetail().subscribe(
      res =>{
        this.resetForm(form);
        this.toastr.success('Submitted Successfully','New Artist Register')
      },
      err =>{console.log(err);}
    );
  }

  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData = new ArtistDetail();
  }

}
