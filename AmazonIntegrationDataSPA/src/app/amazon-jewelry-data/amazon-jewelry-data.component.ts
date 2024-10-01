import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { NgxNotiflixService } from '../ngx-notiflix.service';
import { AmazonJewelryDataService } from './amazon-jewelry-data.service';
import { Pagination, PaginationParam } from '../pagination-utility';

@Component({
  selector: 'app-amazon-jewelry-data',
  templateUrl: './amazon-jewelry-data.component.html',
  styleUrls: ['./amazon-jewelry-data.component.css']
})
export class AmazonJewelryDataComponent implements OnInit
{

  constructor(private notiflix: NgxNotiflixService, private router: Router, private service: AmazonJewelryDataService) { }
  keyword: string = '';
  paramSearch:any
  paginationParam: PaginationParam = {
    pageNumber:1,
    pageSize:50
  }
  listChoosePagination = [
    {
      key:50,
      value:'50 Trang'
    },
    {
      key:2,
      value:'2 Trang'
    },
    {
      key:100,
      value:'100 Trang'
    },
    {
      key:200,
      value:'200 Trang'
    }
  ]
  numberPage = 50;
  listDataAmazon: AmazonJewelryDataFeedItem[] = [];
  pagination : Pagination = <Pagination>{
    pageNumber: 1,
    pageSize: 50,
  };
  ngOnInit(): void
  {
    this.loadData();
  }
  search() {
    this.pagination.pageNumber == 1 ? this.loadData() : this.pagination.pageNumber = 1;
  }
  // thay đổi phân trang
  pageChanged(event: any): void {
    this.pagination.pageNumber = event.page;
    this.loadData();
  }
  filterPagination(e:any){
    if(e == 0){
      e = 1 
    }
    this.pagination.pageSize = e;
    this.loadData();
  }
  loadData()
  {
    this.notiflix.showLoading();
    this.service.getData(this.pagination,this.keyword).subscribe({
      next: res =>
      {
        this.listDataAmazon = res.result;
      },
      error: () =>
      {
        console.log('err');
        this.notiflix.hideLoading();
      },
      complete: () =>
      {
        this.notiflix.hideLoading();
      }
    })
  }
  goToAdd()
  {
    this.router.navigate(['amazon/create']);
  }

  update(item: AmazonJewelryDataFeedItem)
  {
    this.service.storeData(item);
    this.router.navigate(['amazon/update']);
  }

  delete(item: AmazonJewelryDataFeedItem)
  {
    this.notiflix.confirm('Message', 'Do you want delete record?', () =>
    {
      this.notiflix.showLoading();
      this.service.delete(item).subscribe({
        next: res =>
        {
          res.isSuccess ? this.notiflix.success('Deleted Successfully') : this.notiflix.error('Delete failed');
        },
        error: () =>
        {
          this.notiflix.error('Error system');
          this.notiflix.hideLoading();
        },
        complete: () =>
        {
          this.loadData();
          this.notiflix.hideLoading();
        }
      })
    });

  }
}
