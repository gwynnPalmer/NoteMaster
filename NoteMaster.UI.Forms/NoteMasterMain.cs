namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Core;
    using Core.Commands;
    using ScintillaNET;
    using Services;

    public partial class NoteMasterMain : Form
    {
        private readonly CrudeDictionary _crudeDictionary = new CrudeDictionary();
        private List<string> _categories;
        private bool _editModeEnabled;

        public NoteMasterMain()
        {
            InitializeComponent();
            scintilla.Margins[0].Width = 16;
            LoadForm();
            EditModeEnabled = false;
        }

        public string SelectedNoteId => $"{listBoxCategories.SelectedItem}{listBoxTags.SelectedItem}";

        /// <summary>
        ///     Gets or sets a value indicating whether [edit mode enabled].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [edit mode enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool EditModeEnabled
        {
            get => _editModeEnabled;
            set
            {
                _editModeEnabled = value;
                switch (_editModeEnabled)
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

        #region Event-Actions

        private void Scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            var currentPosition = scintilla.CurrentPosition;
            var wordStartPosition = scintilla.WordStartPosition(currentPosition, true);
            var lengthEntered = currentPosition - wordStartPosition;
            if (lengthEntered > 0)
                if (!scintilla.AutoCActive)
                    scintilla.AutoCShow(lengthEntered, _crudeDictionary.Words);
        }

        private void ButtonCreateNewNote_Click(object sender, EventArgs e)
        {
            if (!EditModeEnabled)
            {
                var newNote = new NewNote();
                newNote.FormClosed += NewNote_FormClosed;
                newNote.Show();
            }
            else
            {
                var category = listBoxCategories.SelectedItem.ToString();
                var tag = listBoxTags.SelectedItem.ToString();
                var noteEntry = scintilla.Text.Trim();

                if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(tag) ||
                    string.IsNullOrWhiteSpace(noteEntry)) return;

                var command = new NoteCommand(category, tag, noteEntry);
                if (NoteService.IsMatch(command))
                {
                    NoteService.OverWrite(command);
                    NoteService.ReWriteFile();
                }
                else
                {
                    NoteService.UpdateDatabase(command);
                }

                EditModeEnabled = false;
            }
        }

        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reload();
        }

        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
                listBoxTags.DataSource = NoteService.GetDistinctTags(listBoxCategories.SelectedItem.ToString());
        }

        private void ListBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            scintilla.Clear();
            PopulateNoteBox();
        }

        private void ButtonEditNote_Click(object sender, EventArgs e)
        {
            EditModeEnabled = !EditModeEnabled;
        }

        private void ButtonDeleteNote_Click(object sender, EventArgs e)
        {
            if (SelectedNoteId == null) return;

            var confirmResult = MessageBox.Show($@"Are you sure you wish to delete note {listBoxTags.SelectedItem}?",
                @"Confirm delete.", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                NoteService.Delete(SelectedNoteId);
                NoteService.ReWriteFile();
                Reload();
            }
        }

        #endregion

        #region Methods

        private void Reload()
        {
            scintilla.Clear();
            LoadForm();
            PopulateNoteBox();
        }

        private void ActivateEditMode()
        {
            listBoxCategories.Enabled = false;
            listBoxTags.Enabled = false;
            scintilla.Enabled = true;
            buttonDeleteNote.Enabled = false;
            labelInfo.Text = @"EditModeEnabled enabled - Hit +1up! to save changes.";
        }

        private void DisableEditMode()
        {
            listBoxCategories.Enabled = true;
            listBoxTags.Enabled = true;
            scintilla.Enabled = false;
            buttonDeleteNote.Enabled = true;
            labelInfo.Text = string.Empty;
        }

        public void LoadForm()
        {
            NoteService.FileToBinder(File.ReadAllText(NoteService.FileLocation));
            _categories = NoteService.GetDistinctCategories();
            listBoxCategories.DataSource = _categories;
        }

        private void PopulateNoteBox()
        {
            if (listBoxTags.SelectedItem != null)
                scintilla.Text = NoteService.GetNotesToString(SelectedNoteId);
        }

        #endregion
    }
}