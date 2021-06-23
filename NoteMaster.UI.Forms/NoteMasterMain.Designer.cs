
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
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.richTextBoxNoteOutput = new System.Windows.Forms.RichTextBox();
            this.buttonCreateNewNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(13, 42);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(118, 424);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 15;
            this.listBoxTags.Location = new System.Drawing.Point(139, 42);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(118, 424);
            this.listBoxTags.TabIndex = 1;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.listBoxTags_SelectedIndexChanged);
            // 
            // richTextBoxNoteOutput
            // 
            this.richTextBoxNoteOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNoteOutput.Enabled = false;
            this.richTextBoxNoteOutput.Location = new System.Drawing.Point(264, 42);
            this.richTextBoxNoteOutput.Name = "richTextBoxNoteOutput";
            this.richTextBoxNoteOutput.Size = new System.Drawing.Size(522, 393);
            this.richTextBoxNoteOutput.TabIndex = 2;
            this.richTextBoxNoteOutput.Text = "";
            // 
            // buttonCreateNewNote
            // 
            this.buttonCreateNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewNote.Location = new System.Drawing.Point(13, 13);
            this.buttonCreateNewNote.Name = "buttonCreateNewNote";
            this.buttonCreateNewNote.Size = new System.Drawing.Size(773, 23);
            this.buttonCreateNewNote.TabIndex = 3;
            this.buttonCreateNewNote.Text = "+1up!";
            this.buttonCreateNewNote.UseVisualStyleBackColor = true;
            this.buttonCreateNewNote.Click += new System.EventHandler(this.buttonCreateNewNote_Click);
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditNote.Location = new System.Drawing.Point(264, 444);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(75, 23);
            this.buttonEditNote.TabIndex = 4;
            this.buttonEditNote.Text = "Edit";
            this.buttonEditNote.UseVisualStyleBackColor = true;
            this.buttonEditNote.Click += new System.EventHandler(this.buttonEditNote_Click);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteNote.Location = new System.Drawing.Point(345, 444);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.Text = "Delete";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            // 
            // NoteMasterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.buttonEditNote);
            this.Controls.Add(this.buttonCreateNewNote);
            this.Controls.Add(this.richTextBoxNoteOutput);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.listBoxCategories);
            this.Name = "NoteMasterMain";
            this.Text = "NoteMaster!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.RichTextBox richTextBoxNoteOutput;
        private System.Windows.Forms.Button buttonCreateNewNote;
        public System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonDeleteNote;
    }
}

