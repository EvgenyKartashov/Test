import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from 'rxjs/operators';
import { FederalDistrict } from "../_models/federal-district";

@Injectable({
  providedIn: "root",
})
export class GridService {
  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) { }

  getData(): Observable<FederalDistrict[]> {
    let path = this.baseUrl + "app";
    return this.http
      .get<any[]>(path)
      .pipe(map(data => data.map(fd => new FederalDistrict(fd))));
  }
}
