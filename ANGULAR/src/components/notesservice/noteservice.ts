import {Injectable} from "@angular/core";
import {NoteModel} from "../notes/note.model";

@Injectable()
export class NoteService {

  public sharedNotes: NoteModel[] = [new NoteModel("model1", new Date(Date.now()))];

  constructor() {
  }
}
