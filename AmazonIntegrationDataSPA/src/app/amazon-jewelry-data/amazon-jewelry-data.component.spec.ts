import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AmazonJewelryDataComponent } from './amazon-jewelry-data.component';

describe('AmazonJewelryDataComponent', () => {
  let component: AmazonJewelryDataComponent;
  let fixture: ComponentFixture<AmazonJewelryDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AmazonJewelryDataComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AmazonJewelryDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
