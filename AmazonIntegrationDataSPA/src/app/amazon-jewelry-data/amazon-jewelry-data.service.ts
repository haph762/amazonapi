import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { environment } from 'src/environments/environment';
import { OperationResult } from 'src/operationResult';
import { BehaviorSubject } from 'rxjs';
import { NgxNotiflixService } from '../ngx-notiflix.service';
import { HttpTransportType, HubConnection, HubConnectionBuilder } from '@microsoft/signalr';
import { PaginationParam, PaginationResult } from '../pagination-utility';
@Injectable(
  {
    providedIn: 'root'
  }
)
export class AmazonJewelryDataService
{
  baseURL: string = environment.api;
  dataSource = new BehaviorSubject<AmazonJewelryDataFeedItem>({} as AmazonJewelryDataFeedItem);
  currentDataSource = this.dataSource.asObservable();

  constructor(private notiflix: NgxNotiflixService, private http: HttpClient)
  {

  }
  storeData(model: AmazonJewelryDataFeedItem)
  {
    this.dataSource.next(model);
  }

  getData(pagination: PaginationParam,keyword: string)
  {
    let params = new HttpParams().appendAll({ ...pagination, keyword });
    return this.http.get<PaginationResult<AmazonJewelryDataFeedItem>>(this.baseURL + 'AmazonJewelryDataFeedItemApi/GetData', { params })
  }
  add(model: AmazonJewelryDataFeedItem)
  {
    return this.http.post<OperationResult>(this.baseURL + 'AmazonJewelryDataFeedItemApi/Add', model);
  }
  delete(model: AmazonJewelryDataFeedItem)
  {
    return this.http.put<OperationResult>(this.baseURL + `AmazonJewelryDataFeedItemApi/Delete`, model);
  }
  update(model: AmazonJewelryDataFeedItem)
  {
    return this.http.put<OperationResult>(this.baseURL + 'AmazonJewelryDataFeedItemApi/Update', model);
  }
}
