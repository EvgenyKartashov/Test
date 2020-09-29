export class City {
    id: number;
    name: string;
    parent_id: number;
    parent_name: number;
    federal_district_id: number;

    constructor(data: any) {
        this.id = data.id;
        this.name = data.name;
        this.parent_id = data.parentId;
        this.parent_name = data.parentName;
        this.federal_district_id = data.federalDistrictId;
    }
}
