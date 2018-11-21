import { Component, OnInit } from "@angular/core";

@Component({
    selector: "Home",
    moduleId: module.id,
    templateUrl: "./home.component.html",
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

    charNameInput: string = "";
    listPickerRegions: Array<string> = ["NA", "EU"];
    selectedRegionIndex: number = 0;


    constructor() {
    }

    ngOnInit(): void {
    }


    onSearchIconTap(): void {
        console.log("Searching for " + this.charNameInput);
    }

}
