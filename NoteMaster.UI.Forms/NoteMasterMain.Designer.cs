
namespace NoteMaster.NoteMaster.UI.Forms
{
    partial class NoteMasterMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteMasterMain));
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.buttonCreateNewNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.scintilla = new ScintillaNET.Scintilla();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.button1upCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCategories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(12, 57);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(118, 450);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTags.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTags.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 15;
            this.listBoxTags.Location = new System.Drawing.Point(138, 57);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(118, 450);
            this.listBoxTags.TabIndex = 1;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.ListBoxTags_SelectedIndexChanged);
            // 
            // buttonCreateNewNote
            // 
            this.buttonCreateNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewNote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCreateNewNote.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewNote.Location = new System.Drawing.Point(262, 12);
            this.buttonCreateNewNote.Name = "buttonCreateNewNote";
            this.buttonCreateNewNote.Size = new System.Drawing.Size(527, 23);
            this.buttonCreateNewNote.TabIndex = 3;
            this.buttonCreateNewNote.Text = "+1up!";
            this.buttonCreateNewNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateNewNote.UseVisualStyleBackColor = false;
            this.buttonCreateNewNote.Click += new System.EventHandler(this.ButtonCreateNewNote_Click);
            this.buttonCreateNewNote.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditNote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditNote.FlatAppearance.BorderSize = 0;
            this.buttonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditNote.Location = new System.Drawing.Point(263, 488);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(75, 23);
            this.buttonEditNote.TabIndex = 4;
            this.buttonEditNote.Text = "Edit";
            this.buttonEditNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditNote.UseVisualStyleBackColor = false;
            this.buttonEditNote.Click += new System.EventHandler(this.ButtonEditNote_Click);
            this.buttonEditNote.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteNote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDeleteNote.FlatAppearance.BorderSize = 0;
            this.buttonDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNote.Location = new System.Drawing.Point(344, 488);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.Text = "Delete";
            this.buttonDeleteNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteNote.UseVisualStyleBackColor = false;
            this.buttonDeleteNote.Click += new System.EventHandler(this.ButtonDeleteNote_Click);
            this.buttonDeleteNote.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // scintilla
            // 
            this.scintilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla.AutoCMaxHeight = 9;
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla.EndAtLastLine = false;
            this.scintilla.Location = new System.Drawing.Point(263, 38);
            this.scintilla.MultipleSelection = true;
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(526, 444);
            this.scintilla.TabIndex = 6;
            this.scintilla.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.Scintilla_CharAdded);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(12, 38);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(66, 15);
            this.labelCategories.TabIndex = 8;
            this.labelCategories.Text = "Categories:";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(138, 38);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(33, 15);
            this.labelTags.TabIndex = 9;
            this.labelTags.Text = "Tags:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Location = new System.Drawing.Point(425, 488);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            this.buttonOpen.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // button1upCat
            // 
            this.button1upCat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1upCat.FlatAppearance.BorderSize = 0;
            this.button1upCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1upCat.Location = new System.Drawing.Point(12, 12);
            this.button1upCat.Name = "button1upCat";
            this.button1upCat.Size = new System.Drawing.Size(244, 23);
            this.button1upCat.TabIndex = 11;
            this.button1upCat.Text = "+1up! Category";
            this.button1upCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1upCat.UseVisualStyleBackColor = false;
            this.button1upCat.Click += new System.EventHandler(this.Button1upCat_Click);
            this.button1upCat.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // NoteMasterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(801, 517);
            this.Controls.Add(this.button1upCat);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.buttonEditNote);
            this.Controls.Add(this.buttonCreateNewNote);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.listBoxCategories);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "NoteMasterMain";
            this.Text = "NoteMaster!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.Button buttonCreateNewNote;
        public System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonDeleteNote;
        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button button1upCat;
    }
}

