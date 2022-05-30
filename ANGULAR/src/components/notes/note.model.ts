export class NoteModel {
  public text: String;
  public date: Date;

  constructor(text: String, date: Date) {
    this.text = text;
    this.date = date;
  }
}
