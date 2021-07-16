
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
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(12, 57);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(118, 454);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 15;
            this.listBoxTags.Location = new System.Drawing.Point(138, 57);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(118, 454);
            this.listBoxTags.TabIndex = 1;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.ListBoxTags_SelectedIndexChanged);
            // 
            // buttonCreateNewNote
            // 
            this.buttonCreateNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewNote.Location = new System.Drawing.Point(138, 12);
            this.buttonCreateNewNote.Name = "buttonCreateNewNote";
            this.buttonCreateNewNote.Size = new System.Drawing.Size(651, 23);
            this.buttonCreateNewNote.TabIndex = 3;
            this.buttonCreateNewNote.Text = "+1up!";
            this.buttonCreateNewNote.UseVisualStyleBackColor = true;
            this.buttonCreateNewNote.Click += new System.EventHandler(this.ButtonCreateNewNote_Click);
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditNote.Location = new System.Drawing.Point(266, 488);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(75, 23);
            this.buttonEditNote.TabIndex = 4;
            this.buttonEditNote.Text = "Edit";
            this.buttonEditNote.UseVisualStyleBackColor = true;
            this.buttonEditNote.Click += new System.EventHandler(this.ButtonEditNote_Click);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteNote.Location = new System.Drawing.Point(347, 488);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.Text = "Delete";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            this.buttonDeleteNote.Click += new System.EventHandler(this.ButtonDeleteNote_Click);
            // 
            // scintilla
            // 
            this.scintilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla.AutoCMaxHeight = 9;
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
            this.buttonOpen.Location = new System.Drawing.Point(428, 488);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // button1upCat
            // 
            this.button1upCat.Location = new System.Drawing.Point(12, 12);
            this.button1upCat.Name = "button1upCat";
            this.button1upCat.Size = new System.Drawing.Size(118, 23);
            this.button1upCat.TabIndex = 11;
            this.button1upCat.Text = "+1up! Category";
            this.button1upCat.UseVisualStyleBackColor = true;
            this.button1upCat.Click += new System.EventHandler(this.Button1upCat_Click);
            // 
            // NoteMasterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 526);
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

