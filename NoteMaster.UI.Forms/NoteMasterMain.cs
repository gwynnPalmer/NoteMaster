namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
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

        private void Button_Hover(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#696969");
        }

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
                this.Hide();
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
                    NoteService.ReWriteTextFile();
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
            ReloadForm();
            this.Show();
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
            if (listBoxCategories.SelectedItem != null && listBoxTags.SelectedItem != null)
                EditModeEnabled = !EditModeEnabled;
            else
                MessageBox.Show(@"No note selected.", @"No Puedo.", MessageBoxButtons.OK);
        }

        private void ButtonDeleteNote_Click(object sender, EventArgs e)
        {
            if (SelectedNoteId == null) return;

            var confirmResult = MessageBox.Show($@"Are you sure you wish to delete note {listBoxTags.SelectedItem}?",
                @"Confirm delete.", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            NoteService.Delete(SelectedNoteId);
            NoteService.ReWriteTextFile();
            ReloadForm();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            RestartForm();
        }

        private void Button1upCat_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                var newNote = new NewNote(listBoxCategories.Text);
                newNote.FormClosed += NewNote_FormClosed;
                newNote.Show();
            }
        }

        #endregion

        #region Methods

        public void LoadForm()
        {
            NoteService.FileToBinder(File.ReadAllText(NoteService.TextFileLocation));
            _categories = NoteService.GetDistinctCategories();
            listBoxCategories.DataSource = _categories;
        }

        private void UnloadForm()
        {
            _categories.Clear();
            listBoxTags.DataSource = null;
            listBoxTags.Items.Clear();
            listBoxCategories.DataSource = null;
            listBoxCategories.Items.Clear();
        }

        private void ReloadForm()
        {
            scintilla.Clear();
            LoadForm();
            PopulateNoteBox();
        }

        private void RestartForm()
        {
            NoteService.Binder.Clear();
            UnloadForm();
            NoteService.GetNewFile();
            ReloadForm();
        }

        private void PopulateNoteBox()
        {
            scintilla.Text = listBoxTags.SelectedItem != null
                ? NoteService.GetNotesToString(SelectedNoteId)
                : string.Empty;
        }

        private void ActivateEditMode()
        {
            listBoxCategories.Enabled = false;
            listBoxTags.Enabled = false;
            scintilla.Enabled = true;
            buttonDeleteNote.Enabled = false;
            buttonOpen.Enabled = false;
            button1upCat.Enabled = false;
            Text = @"NoteMaster! [EditMode - Hit +1up! to save changes]";
        }

        private void DisableEditMode()
        {
            listBoxCategories.Enabled = true;
            listBoxTags.Enabled = true;
            scintilla.Enabled = false;
            buttonDeleteNote.Enabled = true;
            buttonOpen.Enabled = true;
            button1upCat.Enabled = true;
            Text = @"NoteMaster!";
        }

        #endregion
    }
}