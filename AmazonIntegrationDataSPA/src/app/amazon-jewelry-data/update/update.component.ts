import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { NgxNotiflixService } from 'src/app/ngx-notiflix.service';
import { AmazonJewelryDataService } from '../amazon-jewelry-data.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit
{
  entity: AmazonJewelryDataFeedItem = {} as AmazonJewelryDataFeedItem;
  constructor(private toastr: NgxNotiflixService, private service: AmazonJewelryDataService,
    private router: Router) { }

  ngOnInit(): void
  {
    this.loadData();
  }

  loadData()
  {
    this.toastr.showLoading();
    this.service.currentDataSource.subscribe({
      next: res =>
      {
        if (!res.id)
        {
          this.router.navigate(['/amazon']);
        }
        this.entity = res;
        this.toastr.hideLoading();
      },
      error: () =>
      {
        this.toastr.error('Error System');
        this.router.navigate(['/amazon']);
      },
      complete: () =>
      {
        this.toastr.hideLoading();
      }
    })
  }

  updatePMC()
  {
    this.toastr.showLoading();
    this.service.update(this.entity).subscribe({
      next: res =>
      {
        res.isSuccess ?
          this.toastr.success('Update Data Successfully')
          : this.toastr.error('Update Data Failed');
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
