import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AmazonJewelryDataComponent } from './amazon-jewelry-data/amazon-jewelry-data.component';
import { CreateComponent } from './amazon-jewelry-data/create/create.component';
import { UpdateComponent } from './amazon-jewelry-data/update/update.component';

const routes: Routes = [
  {
    path: 'amazon',
    component: AmazonJewelryDataComponent
  },
  {
    path: 'amazon/create',
    component: CreateComponent
  },
  {
    path: 'amazon/update',
    component: UpdateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
