using System;
using System.Collections.Generic;
using System.Text;

namespace NoteMaster.NoteMaster.Core.Entities
{
    using System.Linq;
    using Commands;

    public class RingBinder
    {
        public List<Note> Notes;
        public List<string> Categories;

        public RingBinder()
        {
            Notes = new List<Note>();
            foreach (var note in Notes)
            {
                Categories.Add(note.Category);
            }
        }

        public void RefreshCategories()
        {
            Categories.Clear();
            foreach (var note in Notes)
            {
                Categories.Add(note.Category);
            }
        }

        public List<string> ToList()
        {
            var database = new List<string>();

            foreach (var note in Notes) database.Add(note.ToString());

            return database;
        }

        public void FileToBinder(string dataBase)
        {
            Notes.Clear();
            if (string.IsNullOrWhiteSpace(dataBase)) return;
            var trimmedDb = dataBase.Trim();
            var notesArray = trimmedDb.Split("[/Fin]");

            foreach (var note in notesArray)
                if (!string.IsNullOrWhiteSpace(note))
                {
                    var command = new NoteCommand(note.Trim());
                    var newNote = new Note(command);
                    if (!Notes.Contains(newNote)) Notes.Add(newNote);
                }
        }

        public List<string> GetDistinctCategories()
        {
            var categoryIndex = new List<string>();

            foreach (var note in Notes) categoryIndex.Add(note.Category);

            var distinctCategories = categoryIndex.Distinct().ToList();
            distinctCategories.Sort();

            return distinctCategories;
        }

        public List<string> GetDistinctTags(string category)
        {
            var tagIndex = new List<string>();

            foreach (var note in Notes)
                if (note.Category == category && !tagIndex.Contains(note.Tag))
                    tagIndex.Add(note.Tag);

            tagIndex.Sort();
            return tagIndex.Distinct().ToList();
        }

        public string GetNotesToString(string noteId)
        {
            var notes = string.Empty;

            foreach (var note in Notes)
                if (note.NoteId == noteId)
                    notes += note.NoteText.Replace("Note=", string.Empty)
                             + Environment.NewLine + Environment.NewLine;
            return notes;
        }

        public bool IsMatch(NoteCommand command)
        {
            return Notes.Any(note => note.NoteId == command.NoteId);
        }

        public void Update(NoteCommand command)
        {
            var obj = Notes.FirstOrDefault
                (x => x.NoteId == command.NoteId);

            obj?.Update(command);
        }

        public void OverWrite(NoteCommand command)
        {
            var obj = Notes.FirstOrDefault
                (x => x.NoteId == command.NoteId);

            obj?.OverWrite(command);
        }

        public void Delete(string noteId)
        {
            var obj = Notes.FirstOrDefault(x => x.NoteId == noteId);
            Notes.Remove(obj);
        }


    }
}
