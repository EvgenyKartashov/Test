import { HttpClient } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";

@Component({
  selector: "app-grid",
  templateUrl: "./grid.component.html",
  styleUrls: ["./grid.component.css"],
})
export class GridComponent implements OnInit {
  private gridData: any[];

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    http.get<any[]>(baseUrl + "app").subscribe(
      (result) => {
        this.gridData = result;
        console.log(this.gridData);
      },
      (error) => console.error(error)
    );
  }

  ngOnInit() {}
}
