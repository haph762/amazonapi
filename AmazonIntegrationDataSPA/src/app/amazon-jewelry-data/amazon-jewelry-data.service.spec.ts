/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { AmazonJewelryDataService } from './amazon-jewelry-data.service';

describe('Service: AmazonJewelryData', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AmazonJewelryDataService]
    });
  });

  it('should ...', inject([AmazonJewelryDataService], (service: AmazonJewelryDataService) => {
    expect(service).toBeTruthy();
  }));
});
