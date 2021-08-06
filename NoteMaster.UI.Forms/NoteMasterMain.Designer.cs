
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
            this.buttonMinimise = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(560, 55);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(118, 450);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listBoxTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTags.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 15;
            this.listBoxTags.Location = new System.Drawing.Point(686, 55);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(118, 450);
            this.listBoxTags.TabIndex = 1;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.ListBoxTags_SelectedIndexChanged);
            // 
            // buttonCreateNewNote
            // 
            this.buttonCreateNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonCreateNewNote.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonCreateNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewNote.Location = new System.Drawing.Point(469, 9);
            this.buttonCreateNewNote.Name = "buttonCreateNewNote";
            this.buttonCreateNewNote.Size = new System.Drawing.Size(200, 23);
            this.buttonCreateNewNote.TabIndex = 3;
            this.buttonCreateNewNote.Text = "+1up!";
            this.buttonCreateNewNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateNewNote.UseVisualStyleBackColor = false;
            this.buttonCreateNewNote.Click += new System.EventHandler(this.ButtonCreateNewNote_Click);
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonEditNote.FlatAppearance.BorderSize = 0;
            this.buttonEditNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditNote.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditNote.Location = new System.Drawing.Point(262, 9);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(200, 23);
            this.buttonEditNote.TabIndex = 4;
            this.buttonEditNote.Text = "[EditMode]";
            this.buttonEditNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditNote.UseVisualStyleBackColor = false;
            this.buttonEditNote.Click += new System.EventHandler(this.ButtonEditNote_Click);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonDeleteNote.FlatAppearance.BorderSize = 0;
            this.buttonDeleteNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNote.Location = new System.Drawing.Point(136, 9);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(57, 23);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.Text = "Delete";
            this.buttonDeleteNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteNote.UseVisualStyleBackColor = false;
            this.buttonDeleteNote.Click += new System.EventHandler(this.ButtonDeleteNote_Click);
            // 
            // scintilla
            // 
            this.scintilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla.AutoCMaxHeight = 9;
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla.EndAtLastLine = false;
            this.scintilla.Location = new System.Drawing.Point(12, 38);
            this.scintilla.MultipleSelection = true;
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(542, 467);
            this.scintilla.TabIndex = 6;
            this.scintilla.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.Scintilla_CharAdded);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(560, 36);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(66, 15);
            this.labelCategories.TabIndex = 8;
            this.labelCategories.Text = "Categories:";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(686, 36);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(33, 15);
            this.labelTags.TabIndex = 9;
            this.labelTags.Text = "Tags:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Location = new System.Drawing.Point(199, 9);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(57, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // button1upCat
            // 
            this.button1upCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1upCat.FlatAppearance.BorderSize = 0;
            this.button1upCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.button1upCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1upCat.Location = new System.Drawing.Point(12, 9);
            this.button1upCat.Name = "button1upCat";
            this.button1upCat.Size = new System.Drawing.Size(118, 23);
            this.button1upCat.TabIndex = 11;
            this.button1upCat.Text = "+1up! Category";
            this.button1upCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1upCat.UseVisualStyleBackColor = false;
            this.button1upCat.Click += new System.EventHandler(this.Button1upCat_Click);
            // 
            // buttonMinimise
            // 
            this.buttonMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimise.FlatAppearance.BorderSize = 0;
            this.buttonMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimise.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimise.Location = new System.Drawing.Point(753, 9);
            this.buttonMinimise.Name = "buttonMinimise";
            this.buttonMinimise.Size = new System.Drawing.Size(23, 23);
            this.buttonMinimise.TabIndex = 12;
            this.buttonMinimise.Text = "-";
            this.buttonMinimise.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimise.UseVisualStyleBackColor = true;
            this.buttonMinimise.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(782, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "×";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // NoteMasterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(817, 517);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMinimise);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(817, 400);
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
        private System.Windows.Forms.Button buttonMinimise;
        private System.Windows.Forms.Button buttonMaximise;
        private System.Windows.Forms.Button buttonClose;
    }
}

