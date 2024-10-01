import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { AmazonJewelryDataService } from './amazon-jewelry-data/amazon-jewelry-data.service';
import { SignalRService } from './signalR.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit
{
  title = 'Amazon Integration Data SPA';
  listDataAmazon: AmazonJewelryDataFeedItem[] = [];
  keyword: string = '';
  constructor(private router: Router, private service: AmazonJewelryDataService,
    private serviceSignalR: SignalRService)
  {

  }
  ngOnInit(): void
  {
    this.serviceSignalR.startConnection();
    this.serviceSignalR.addNotificationChangedListener();
    this.loadData();
    this.loadNotification();
  }

  loadNotification()
  {
    this.serviceSignalR.notificationChangedEmitter.subscribe(res =>
    {
      if (res.id != null)
      {
        this.loadData();
      }
    })
  }
  loadData()
  {
    this.service.getData(null,this.keyword).subscribe({
      next: res =>
      {
        this.listDataAmazon = res.result;
      },
      error: () =>
      {
        console.log('err');
      },
      complete: () =>
      {
      }
    })
  }
  link()
  {
    this.router.navigate(['amazon'])
  }
}
