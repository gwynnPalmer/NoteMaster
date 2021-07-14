namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Windows.Forms;
    using Core;
    using Core.Commands;
    using ScintillaNET;
    using Services;

    public partial class NewNote : Form
    {
        private readonly CrudeDictionary _crudeDictionary = new CrudeDictionary();

        /// <summary>
        ///     Initializes a new instance of the <see cref="NewNote" /> class.
        /// </summary>
        public NewNote()
        {
            InitializeComponent();
            scintillaNew.Margins[0].Width = 16;
        }

        /// <summary>
        ///     Handles the Click event of the buttonSaveNewNote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ButtonSaveNewNote_Click(object sender, EventArgs e)
        {
            var category = textBoxCategory.Text.Trim();
            var tag = textBoxTag.Text.Trim();
            var noteEntry = scintillaNew.Text.Trim();

            if (!string.IsNullOrWhiteSpace(category) &&
                !string.IsNullOrWhiteSpace(tag) &&
                !string.IsNullOrWhiteSpace(noteEntry))
            {
                var command = new NoteCommand(category, $"#{tag}", noteEntry);

                if (NoteService.IsMatch(command))
                {
                    NoteService.Update(command);
                    NoteService.ReWriteTextFile();
                }
                else
                {
                    NoteService.UpdateDatabase(command);
                }
            }

            Close();
        }

        private void Scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            var currentPosition = scintillaNew.CurrentPosition;
            var wordStartPosition = scintillaNew.WordStartPosition(currentPosition, true);
            var lengthEntered = currentPosition - wordStartPosition;
            if (lengthEntered > 0)
                if (!scintillaNew.AutoCActive)
                    scintillaNew.AutoCShow(lengthEntered, _crudeDictionary.Words);
        }
    }
}