﻿namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Core.Commands;
    using Services;

    public partial class NoteMasterMain : Form
    {
        /// <summary>
        ///     The categories
        /// </summary>
        private List<string> _categories;

        /// <summary>
        /// The edit mode enabled enabled
        /// </summary>
        private bool _editModeEnabledEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteMasterMain"/> class.
        /// </summary>
        public NoteMasterMain()
        {
            InitializeComponent();
            scintilla.Margins[0].Width = 16;
            LoadForm();
            EditModeEnabled = false;
        }

        /// <summary>
        /// Gets the selected note identifier.
        /// </summary>
        /// <value>
        /// The selected note identifier.
        /// </value>
        public string SelectedNoteId => $"{listBoxCategories.SelectedItem}{listBoxTags.SelectedItem}";

        /// <summary>
        /// Gets or sets a value indicating whether [edit mode enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [edit mode enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool EditModeEnabled
        {
            get => _editModeEnabledEnabled;
            set
            {
                _editModeEnabledEnabled = value;
                switch (_editModeEnabledEnabled)
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

        /// <summary>
        /// Activates the edit mode.
        /// </summary>
        private void ActivateEditMode()
        {
            listBoxCategories.Enabled = false;
            listBoxTags.Enabled = false;
            scintilla.Enabled = true;
            buttonDeleteNote.Enabled = false;
            labelInfo.Text = @"EditModeEnabled enabled - Hit +1up! to save changes.";
        }

        /// <summary>
        /// Disables the edit mode.
        /// </summary>
        private void DisableEditMode()
        {
            listBoxCategories.Enabled = true;
            listBoxTags.Enabled = true;
            scintilla.Enabled = false;
            buttonDeleteNote.Enabled = true;
            labelInfo.Text = string.Empty;
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
                scintilla.Text = NoteService.GetNotesToString(SelectedNoteId);
        }

        /// <summary>
        ///     Handles the Click event of the buttonCreateNewNote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
                    NoteService.ReWriteDataBase();
                }
                else
                {
                    NoteService.UpdateDatabase(command);
                }

                EditModeEnabled = false;
            }
        }

        /// <summary>
        ///     Handles the formClosed event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs" /> instance containing the event data.</param>
        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            scintilla.Clear();
            LoadForm();
            PopulateNoteBox();
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the listBoxCategories control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
                listBoxTags.DataSource = NoteService.GetDistinctTags(listBoxCategories.SelectedItem.ToString());
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the listBoxTags control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ListBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            scintilla.Clear();
            PopulateNoteBox();
        }

        private void ButtonEditNote_Click(object sender, EventArgs e)
        {
            EditModeEnabled = !EditModeEnabled;
        }
    }
}