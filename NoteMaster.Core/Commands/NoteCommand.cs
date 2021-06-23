namespace NoteMaster.NoteMaster.Core.Commands
{
    public class NoteCommand
    {
        public NoteCommand(string dbEntry)
        {
            var entryContents = dbEntry.Split("[;]");
            Category = entryContents[0].Replace("Category=", string.Empty).Trim();
            Tag = entryContents[1].Replace("Tag=", string.Empty).Trim();
            NoteText = entryContents[2].Replace("Note=", string.Empty).Trim();
        }

        public NoteCommand(string category, string tag, string text)
        {
            Category = category;
            Tag = tag;
            NoteText = text;
        }

        public string Category { get; set; }
        public string Tag { get; set; }
        public string NoteText { get; set; }
        public string NoteId => $"{Category}{Tag}";
    }
}