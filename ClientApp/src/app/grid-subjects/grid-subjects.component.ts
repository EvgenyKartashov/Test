import { Component, Input, OnInit } from '@angular/core';
import { Subject } from '../_models/subject';

@Component({
  selector: 'app-grid-subjects',
  templateUrl: './grid-subjects.component.html',
  styleUrls: ['./grid-subjects.component.css']
})
export class GridSubjectsComponent implements OnInit {

  @Input()
  public subjects: Subject[];

  @Input()
  public parentRow: number;

  constructor() { }

  ngOnInit() {
  }
}
