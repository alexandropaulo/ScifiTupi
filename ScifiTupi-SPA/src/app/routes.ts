import { Routes } from "@angular/router";
import { ContentComponent } from "./content/content.component";
import { HomeComponent } from "./home/home.component";

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    { path: ':page', component: ContentComponent},
    { path: '**', redirectTo: '', pathMatch: 'full'},
];