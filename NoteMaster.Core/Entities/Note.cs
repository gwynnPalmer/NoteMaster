namespace NoteMaster.NoteMaster.Core.Entities
{
    using System;
    using Commands;

    public class Note
    {
        public Note(NoteCommand command)
        {
            Category = command.Category;
            Tag = command.Tag;
            NoteText = command.NoteText;
        }

        public string Category { get; set; }
        public string Tag { get; set; }
        public string NoteText { get; set; }
        public string NoteId => $"{Category}{Tag}";


        public override string ToString()
        {
            var newEntry = string.Format($"Category={Category}[;]Tag={Tag}[;]Note={NoteText}[/Fin]");
            return newEntry;
        }

        public void Update(NoteCommand command)
        {
            if (NoteId == command.NoteId)
                NoteText += Environment.NewLine + Environment.NewLine + command.NoteText;
        }

        public void OverWrite(NoteCommand command)
        {
            if (NoteId == command.NoteId)
                NoteText = command.NoteText;
        }
    }
}