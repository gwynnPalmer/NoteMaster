namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Windows.Forms;
    using Core.Commands;
    using Services;

    public partial class NewNote : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NewNote" /> class.
        /// </summary>
        public NewNote()
        {
            InitializeComponent();
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
            var noteEntry = textBoxNote.Text.Trim();

            if (!string.IsNullOrWhiteSpace(category) &&
                !string.IsNullOrWhiteSpace(tag) &&
                !string.IsNullOrWhiteSpace(noteEntry))
            {
                var command = new NoteCommand(category, $"#{tag}", noteEntry);

                if (NoteService.IsMatch(command))
                {
                    NoteService.Update(command);
                    NoteService.ReWriteDataBase();
                }
                else
                {
                    NoteService.UpdateDatabase(command);
                }
            }

            Close();
        }
    }
}