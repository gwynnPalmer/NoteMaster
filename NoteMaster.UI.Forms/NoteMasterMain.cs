namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using global::NoteMaster.NoteMaster.Core.Commands;
    using global::NoteMaster.NoteMaster.Services;

    public partial class NoteMasterMain : Form
    {
        /// <summary>
        ///     The categories
        /// </summary>
        private List<string> _categories;

        private bool _editMode;

        /// <summary>
        ///     Initializes a new instance of the <see cref="NoteMasterMain" /> class.
        /// </summary>
        public NoteMasterMain()
        {
            InitializeComponent();
            LoadForm();
        }

        public string SelectedNoteId => $"{listBoxCategories.SelectedItem}{listBoxTags.SelectedItem}";

        //public bool EditMode { get; protected set; }
        public bool EditMode
        {
            get => _editMode;
            set
            {
                _editMode = value;
                switch (_editMode)
                {
                    case true:
                        ActivateEditMode();
                        break;
                    case false:
                        DisableEditMode();
                        break;
                }
            }
        }
        
        private void ActivateEditMode()
        {
            listBoxCategories.Enabled = false;
            listBoxTags.Enabled = false;
            richTextBoxNoteOutput.Enabled = true;
            buttonDeleteNote.Enabled = false;
        }

        private void DisableEditMode()
        {
            listBoxCategories.Enabled = true;
            listBoxTags.Enabled = true;
            richTextBoxNoteOutput.Enabled = false;
            buttonDeleteNote.Enabled = true;
        }

        /// <summary>
        ///     Loads the form.
        /// </summary>
        public void LoadForm()
        {
            NoteService.FileToBinder(File.ReadAllText(NoteService.DbLocation));
            _categories = NoteService.GetDistinctCategories();
            listBoxCategories.DataSource = _categories;
        }

        /// <summary>
        ///     Populates the note box.
        /// </summary>
        private void PopulateNoteBox()
        {
            if (listBoxTags.SelectedItem != null)
                richTextBoxNoteOutput.Text = NoteService.GetNotesToString(SelectedNoteId);
        }

        /// <summary>
        ///     Handles the Click event of the buttonCreateNewNote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonCreateNewNote_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                var newNote = new NewNote();
                newNote.FormClosed += NewNote_FormClosed;
                newNote.Show();
            }
            else
            {
                var category = listBoxCategories.SelectedItem.ToString();
                var tag = listBoxTags.SelectedItem.ToString();
                var noteEntry = richTextBoxNoteOutput.Text.Trim();

                if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(tag) ||
                    string.IsNullOrWhiteSpace(noteEntry)) return;

                var command = new NoteCommand(category, tag, noteEntry);
                if (NoteService.IsMatch(command))
                {
                    NoteService.OverWrite(command);
                    NoteService.ReWriteDataBase();
                }
                else
                {
                    NoteService.UpdateDatabase(command);
                }

                EditMode = false;
            }
        }

        /// <summary>
        ///     Handles the formClosed event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs" /> instance containing the event data.</param>
        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            richTextBoxNoteOutput.Clear();
            LoadForm();
            PopulateNoteBox();
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the listBoxCategories control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
                listBoxTags.DataSource = NoteService.GetDistinctTags(listBoxCategories.SelectedItem.ToString());
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the listBoxTags control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void listBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxNoteOutput.Clear();
            PopulateNoteBox();
        }

        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            EditMode = !EditMode;
        }
    }
}