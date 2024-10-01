import { HttpClient } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';
// import { HttpTransportType, HubConnection, HubConnectionBuilder } from '@microsoft/signalr';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { environment } from 'src/environments/environment';
import * as signalR from '@microsoft/signalr';
@Injectable()
export class SignalRService
{
  private hubConnection: signalR.HubConnection;
  notificationChangedEmitter: EventEmitter<AmazonJewelryDataFeedItem>;

  constructor(private http: HttpClient)
  {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('/hub')
      .build();
    this.notificationChangedEmitter = new EventEmitter();
  }
  /**
    * Bắt đầu connection
    */
  startConnection()
  {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(`${ environment.baseUrl }notificationHub`, {
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets
      })
      .withAutomaticReconnect()
      .build();

    this.hubConnection
      .start()
      .catch((err: string) => console.log('Error while starting connection: ' + err));
  }
  /**
   * vd
   */
  addNotificationChangedListener()
  {
    this.hubConnection.on("DataAmazon", (data: AmazonJewelryDataFeedItem) =>
    {
      this.notificationChangedEmitter.emit(data);
    });
  }

}
