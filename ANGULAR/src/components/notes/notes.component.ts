import { Component } from '@angular/core';
import {NoteModel} from "./note.model";
import {newArray} from "@angular/compiler/src/util";
import {NoteService} from "../notesservice/noteservice";

@Component({
  selector: 'note-component',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.css'],
})
export class NotesComponent {
  title = 'Notes Component';
  notes: NoteModel[] = [new NoteModel("model1", new Date(Date.now()))];
  constructor(private noteService: NoteService) {
    this.notes = this.noteService.sharedNotes;
  }
}
