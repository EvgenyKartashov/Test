import { Subject } from "./subject";

export class FederalDistrict {
    id: number;
    name: number;
    women_kid: number;
    women_adult: number;
    women_senior: number;
    men_kid: number;
    men_adult: number;
    men_senior: number;
    sum: number;
    curator_id: number;
    operator_id: number;
    subjects: Subject[];

    constructor(data: any) {
        this.id = data.id;
        this.name = data.name;
        this.women_kid = data.womenKid;
        this.women_adult = data.womenAdult;
        this.women_senior = data.womenSenior;
        this.men_kid = data.menKid;
        this.men_adult = data.menAdult;
        this.men_senior = data.menSenior;
        this.sum = data.sum;
        this.curator_id = data.operatorId;
        this.subjects = (data.subjects as any[]).map(data => new Subject(data));
    }
}
