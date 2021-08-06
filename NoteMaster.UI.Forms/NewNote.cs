namespace NoteMaster.NoteMaster.UI.Forms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Core;
    using Core.Commands;
    using ScintillaNET;
    using Services;

    public partial class NewNote : Form
    {
        private const int cGrip = 16; // Grip size
        private const int cCaption = 32; // Caption bar height;
        private readonly CrudeDictionary _crudeDictionary = new CrudeDictionary();

        /// <summary>
        ///     Initializes a new instance of the <see cref="NewNote" /> class.
        /// </summary>
        public NewNote()
        {
            GetFreshForm();
        }

        public NewNote(string seedCategory)
        {
            InitializeComponent();
            scintillaNew.Margins[0].Width = 16;
            comboBoxCategories.DataSource = NoteService.Categories;
            comboBoxCategories.Text = seedCategory;
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rectangle = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rectangle);
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x84)
            {
                var point = new Point(message.LParam.ToInt32());
                point = PointToClient(point);
                if (point.Y < cCaption)
                {
                    message.Result = (IntPtr)2;
                    return;
                }

                if (point.X >= ClientSize.Width - cGrip && point.Y >= ClientSize.Height - cGrip)
                {
                    message.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref message);
        }


        /// <summary>
        ///     Handles the Click event of the buttonSaveNewNote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ButtonSaveNewNote_Click(object sender, EventArgs e)
        {
            var category = comboBoxCategories.Text.Trim();
            var tag = comboBoxTags.Text.Trim();
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
        
        private void Update_Tags(object sender, EventArgs e)
        {
            comboBoxTags.DataSource = NoteService.GetDistinctTags(comboBoxCategories.Text);
        }

        private void GetFreshForm()
        {
            InitializeComponent();
            scintillaNew.Margins[0].Width = 16;
            comboBoxCategories.DataSource = NoteService.Categories;
            comboBoxCategories.SelectedItem = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}