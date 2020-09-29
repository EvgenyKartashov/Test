import { City } from "./city";
import { Route } from "./route";

export class Subject {
    id: number;
    parent_id: number;
    name: number;
    women_kid: number;
    women_adult: number;
    women_senior: number;
    men_kid: number;
    men_adult: number;
    men_senior: number;
    sum: number;
    cities: City[];
    routes: Route[];

    constructor(data: any) {
        this.id = data.id;
        this.parent_id = data.parentId;
        this.name = data.name;
        this.women_kid = data.womenKid;
        this.women_adult = data.womenAdult;
        this.women_senior = data.womenSenior;
        this.men_kid = data.menKid;
        this.men_adult = data.menAdult;
        this.men_senior = data.menSenior;
        this.sum = data.sum;
        this.cities = (data.cities as any[]).map(data => new City(data));
        this.routes = (data.routes as any[]).map(data => new Route(data));
    }
}
