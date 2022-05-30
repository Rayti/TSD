import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AddnoteComponent} from "../addnote/addnote.component";
import {MainmenuComponent} from "../mainmenu/mainmenu.component";
import {NotesComponent} from "../notes/notes.component";
import {AppComponent} from "../../app/app.component";

const routes: Routes = [
  { path: 'add', component: AddnoteComponent },
  { path: 'mainmenu', component: MainmenuComponent},
  { path: 'notes', component: NotesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  bootstrap: [AppComponent]
})
export class AppRoutingModule { }
