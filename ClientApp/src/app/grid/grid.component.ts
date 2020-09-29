import { Component, OnInit } from "@angular/core";
import { FederalDistrict } from "../_models/federal-district";
import { GridService } from "./grid.service";

@Component({
  selector: "app-grid",
  templateUrl: "./grid.component.html",
  styleUrls: ["./grid.component.css"],
  providers: [GridService],
})
export class GridComponent implements OnInit {
  federalDistricts: FederalDistrict[];

  constructor(private gridService: GridService) { }

  ngOnInit() {
    this.refreshData();
  }

  refreshData() {
    this.gridService.getData().subscribe(
      (result) => (this.federalDistricts = result),  
      (error) => console.error(error)
    );
  }
}
