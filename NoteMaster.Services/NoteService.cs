namespace NoteMaster.NoteMaster.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Core.Commands;
    using Core.Entities;

    public static class NoteService
    {
        /// <summary>
        ///     The binder
        /// </summary>
        public static List<Note> Binder = new List<Note>();

        /// <summary>
        ///     Gets the database location.
        /// </summary>
        /// <value>
        ///     The database location.
        /// </value>
        public static string DbLocation { get; private set; }

        /// <summary>
        ///     Sets the database location.
        /// </summary>
        public static void SetDbLocation()
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"Txt files (*.txt)|*.txt",
                Title = @"Assign your Database."
            };
            saveFileDialog1.ShowDialog();
            DbLocation = saveFileDialog1.FileName;
        }

        /// <summary>
        ///     ReWrites the data base .txt file with data from the Binder.
        /// </summary>
        public static void ReWriteDataBase()
        {
            var newDb = string.Join(string.Empty, BinderToString());

            var sw = new StreamWriter(DbLocation);
            sw.WriteLine(newDb);
            sw.Close();
        }

        private static string DatabaseToString()
        {
            var sr = new StreamReader(DbLocation);
            var previousNotes = sr.ReadToEnd();
            sr.Close();
            return previousNotes;
        }

        /// <summary>
        ///     ReWrites the data base .txt file with data from the command.
        /// </summary>
        /// <param name="command">The command.</param>
        public static void UpdateDatabase(NoteCommand command)
        {
            var previousNotes = DatabaseToString();
            var sw = new StreamWriter(DbLocation);
            sw.WriteLine(previousNotes + new Note(command));
            sw.Close();
        }

        public static void UpdateDatabase(NoteCommand command, string previousNotes)
        {
            var sw = new StreamWriter(DbLocation);
            sw.WriteLine(previousNotes + new Note(command));
            sw.Close();
        }

        /// <summary>
        ///     Converts all Notes in binder to string format and returns the result as a List.
        /// </summary>
        /// <returns></returns>
        private static List<string> BinderToString()
        {
            var database = new List<string>();

            foreach (var note in Binder) database.Add(note.ToString());

            return database;
        }

        /// <summary>
        ///     Files the database string binder.
        /// </summary>
        /// <param name="dataBase">The data base.</param>
        public static void FileToBinder(string dataBase)
        {
            Binder.Clear();
            if (string.IsNullOrWhiteSpace(dataBase)) return;
            var trimmedDb = dataBase.Trim();
            var notesArray = trimmedDb.Split("[/Fin]");

            foreach (var note in notesArray)
                if (!string.IsNullOrWhiteSpace(note))
                {
                    var command = new NoteCommand(note.Trim());
                    var newNote = new Note(command);
                    if (!Binder.Contains(newNote)) Binder.Add(newNote);
                }
        }

        /// <summary>
        ///     Gets the distinct categories.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDistinctCategories()
        {
            var categoryIndex = new List<string>();

            foreach (var note in Binder) categoryIndex.Add(note.Category);

            var distinctCategories = categoryIndex.Distinct().ToList();
            distinctCategories.Sort();

            return distinctCategories;
        }

        /// <summary>
        ///     Gets the distinct tags.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        public static List<string> GetDistinctTags(string category)
        {
            var tagIndex = new List<string>();

            foreach (var note in Binder)
                if (note.Category == category && !tagIndex.Contains(note.Tag))
                    tagIndex.Add(note.Tag);

            tagIndex.Sort();
            return tagIndex.Distinct().ToList();
        }

        /// <summary>
        ///     Gets the notes to string.
        /// </summary>
        /// <param name="noteId">The note identifier.</param>
        /// <returns></returns>
        public static string GetNotesToString(string noteId)
        {
            var notes = string.Empty;

            foreach (var note in Binder)
                if (note.NoteId == noteId)
                    notes += note.NoteText.Replace("Note=", string.Empty)
                             + Environment.NewLine + Environment.NewLine;
            return notes;
        }

        /// <summary>
        ///     Determines whether the specified command matches an existing Note.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>
        ///     <c>true</c> if the specified command is match; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMatch(NoteCommand command)
        {
            return Binder.Any(note => note.NoteId == command.NoteId);
        }

        /// <summary>
        ///     Updates the matching Note.
        /// </summary>
        /// <param name="command">The command.</param>
        public static void Update(NoteCommand command)
        {
            var obj = Binder.FirstOrDefault
                (x => x.NoteId == command.NoteId);

            obj?.Update(command);
        }

        public static void OverWrite(NoteCommand command)
        {
            var obj = Binder.FirstOrDefault
                (x => x.NoteId == command.NoteId);

            obj?.OverWrite(command);
        }
    }
}