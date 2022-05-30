import { Component } from '@angular/core';
import {NoteService} from "../notesservice/noteservice";
import {NoteModel} from "../notes/note.model";


@Component({
  selector: 'addnote-component',
  templateUrl: './addnote.component.html',
  styleUrls: ['./addnote.component.css']
})
export class AddnoteComponent {
  title = 'Add Note Component';
  noteText = "";
  noteDate: Date = Date.prototype;
  onSave() {
    this.noteService.sharedNotes.push(new NoteModel(this.noteText, this.noteDate));

  }

  constructor(private noteService: NoteService) {
  }
}
