import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {NotesComponent} from "../components/notes/notes.component";
import {AppRoutingModule} from "../components/routing/approuting.module";
import {RouterModule} from "@angular/router";
import {MainmenuComponent} from "../components/mainmenu/mainmenu.component";
import {AddnoteComponent} from "../components/addnote/addnote.component";
import {FormsModule} from "@angular/forms";
import {NoteService} from "../components/notesservice/noteservice";

@NgModule({
  declarations: [
    AppComponent,
    NotesComponent,
    MainmenuComponent,
    AddnoteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    FormsModule
  ],
  providers: [NoteService],
  bootstrap: [AppComponent]
})
export class AppModule { }
