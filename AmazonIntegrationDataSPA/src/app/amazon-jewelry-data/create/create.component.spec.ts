import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Router } from '@angular/router';
import { Observable, of, throwError } from 'rxjs';
import { AmazonJewelryDataFeedItem } from 'src/amazonJewelryDataFeedItem';
import { OperationResult } from 'src/operationResult';
import { AmazonJewelryDataService } from '../amazon-jewelry-data.service';
import { NgxNotiflixService } from './../../ngx-notiflix.service';
import { CreateComponent } from './create.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
describe('CreateComponent', () =>
{
  let component: CreateComponent;
  let fixture: ComponentFixture<CreateComponent>;
  let toastrService: NgxNotiflixService;
  let router: Router;
  let service: AmazonJewelryDataService;

  beforeEach(async () =>
  {
    toastrService = jasmine.createSpyObj('NgxNotiflixService', ['showLoading', 'success', 'error', 'hideLoading']);
    router = jasmine.createSpyObj('Router', ['navigate']);
    service = jasmine.createSpyObj('AmazonJewelryDataService', ['add']);

    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [
        { provide: NgxNotiflixService, useValue: toastrService },
        { provide: Router, useValue: router },
        { provide: AmazonJewelryDataService, useValue: service },
      ],
    });
    service = TestBed.inject(AmazonJewelryDataService);
  });

  beforeEach(() =>
  {
    fixture = TestBed.createComponent(CreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () =>
  {
    expect(component).toBeTruthy();
  });

  it('should call service.add() with correct parameter', () =>
  {
    // arrange
    const expectedData: AmazonJewelryDataFeedItem = {} as AmazonJewelryDataFeedItem;
    component.entity = expectedData;
    const addSpy = jasmine.createSpy().and.returnValue(of({ isSuccess: true })) as jasmine.Spy<(model: AmazonJewelryDataFeedItem) => Observable<OperationResult>>;

    // act
    component.AddPMC();

    // assert
    expect(addSpy).toHaveBeenCalledWith(expectedData);
  });

  it('should show success message on success', () =>
  {
    // arrange
    const expectedData: AmazonJewelryDataFeedItem = { /* your mock data */ } as AmazonJewelryDataFeedItem;
    component.entity = expectedData;
    jasmine.createSpy().and.returnValue(of({ isSuccess: true })) as jasmine.Spy<(model: AmazonJewelryDataFeedItem) => Observable<OperationResult>>;

    // act
    component.AddPMC();

    // assert
    expect(toastrService.success).toHaveBeenCalledWith('Add Data Successfully');
    expect(toastrService.error).not.toHaveBeenCalled();
  });

  it('should show error message on error', () =>
  {
    // arrange
    const expectedData: AmazonJewelryDataFeedItem = { /* your mock data */ } as AmazonJewelryDataFeedItem;
    component.entity = expectedData;
    jasmine.createSpy().and.returnValue(of({ error: 'error' })) as jasmine.Spy<(model: AmazonJewelryDataFeedItem) => Observable<OperationResult>>;

    // act
    component.AddPMC();

    // assert
    expect(toastrService.error).toHaveBeenCalledWith('Error System');
    expect(toastrService.success).not.toHaveBeenCalled();
  });

  it('should navigate to /amazon on complete', () =>
  {
    // arrange
    const expectedData: AmazonJewelryDataFeedItem = { /* your mock data */ } as AmazonJewelryDataFeedItem;
    component.entity = expectedData;
    jasmine.createSpy().and.returnValue(of({ isSuccess: true })) as jasmine.Spy<(model: AmazonJewelryDataFeedItem) => Observable<OperationResult>>;

    // act
    component.AddPMC();

    // assert
    expect(router.navigate).toHaveBeenCalledWith(['/amazon']);
  });
});
