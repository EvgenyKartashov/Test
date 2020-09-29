export class Route {
    id: number;
    parent_id: number;
    name: string;
    women_kid: number;
    women_adult: number;
    women_senior: number;
    men_kid: number;
    men_adult: number;
    men_senior: number;
    sum: number;
    city_from_id: number;
    city_to_id: number;
    city_from: string;
    city_to: string;

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
        this.city_from_id = data.cityFromId;
        this.city_to_id = data.cityToId;
        this.city_from = data.cityFrom;
        this.city_to = data.cityTo;
    }
}
