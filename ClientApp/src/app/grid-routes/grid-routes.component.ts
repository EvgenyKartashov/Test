import { Component, Input, OnInit } from '@angular/core';
import { Route } from '../_models/route';

@Component({
  selector: 'app-grid-routes',
  templateUrl: './grid-routes.component.html',
  styleUrls: ['./grid-routes.component.css']
})
export class GridRoutesComponent implements OnInit {

  @Input()
  public routes: Route[];

  @Input()
  public mainParentRow: number;

  @Input()
  public parentRow: number;

  constructor() { }

  ngOnInit() {
  }

}
