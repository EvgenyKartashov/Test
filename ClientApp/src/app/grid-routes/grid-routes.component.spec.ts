import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GridRoutesComponent } from './grid-routes.component';

describe('GridRoutesComponent', () => {
  let component: GridRoutesComponent;
  let fixture: ComponentFixture<GridRoutesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridRoutesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridRoutesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
