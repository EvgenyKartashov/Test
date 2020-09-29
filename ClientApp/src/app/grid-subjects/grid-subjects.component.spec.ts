import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GridSubjectsComponent } from './grid-subjects.component';

describe('GridSubjectsComponent', () => {
  let component: GridSubjectsComponent;
  let fixture: ComponentFixture<GridSubjectsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridSubjectsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridSubjectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
