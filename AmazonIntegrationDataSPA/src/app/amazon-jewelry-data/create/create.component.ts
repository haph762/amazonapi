import { Component, OnInit } from '@angular/core';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { AmazonJewelryDataService } from '../amazon-jewelry-data.service';
import { Router } from '@angular/router';
import { NgxNotiflixService } from './../../ngx-notiflix.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit
{
  entity: AmazonJewelryDataFeedItem = {} as AmazonJewelryDataFeedItem;
  constructor(private toastr: NgxNotiflixService, private service: AmazonJewelryDataService,
    private router: Router) { }

  ngOnInit(): void
  {
  }
  AddPMC()
  {
    this.toastr.showLoading();
    this.service.add(this.entity).subscribe({
      next: res =>
      {
        res.isSuccess ?
          this.toastr.success('Add Data Successfully')
          : this.toastr.error('Add Data Failed');
      },
      error: () =>
      {
        this.toastr.error('Error System');
      },
      complete: () =>
      {
        this.router.navigate(['/amazon']);
        this.toastr.hideLoading();
      }
    })
  }
}
