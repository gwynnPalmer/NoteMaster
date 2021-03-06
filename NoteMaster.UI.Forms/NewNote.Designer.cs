
namespace NoteMaster.NoteMaster.UI.Forms
{
    partial class NewNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNote));
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.scintillaNew = new ScintillaNET.Scintilla();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveNewNote = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTags.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxTags.FormattingEnabled = true;
            this.comboBoxTags.Location = new System.Drawing.Point(238, 6);
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTags.TabIndex = 2;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(73, 6);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategories.TabIndex = 1;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.Update_Tags);
            // 
            // scintillaNew
            // 
            this.scintillaNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaNew.AutoCMaxHeight = 9;
            this.scintillaNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaNew.EndAtLastLine = false;
            this.scintillaNew.Location = new System.Drawing.Point(12, 35);
            this.scintillaNew.Name = "scintillaNew";
            this.scintillaNew.Size = new System.Drawing.Size(594, 396);
            this.scintillaNew.TabIndex = 3;
            this.scintillaNew.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.Scintilla_CharAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "#Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // buttonSaveNewNote
            // 
            this.buttonSaveNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonSaveNewNote.FlatAppearance.BorderSize = 0;
            this.buttonSaveNewNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonSaveNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNewNote.Location = new System.Drawing.Point(365, 6);
            this.buttonSaveNewNote.Name = "buttonSaveNewNote";
            this.buttonSaveNewNote.Size = new System.Drawing.Size(138, 23);
            this.buttonSaveNewNote.TabIndex = 0;
            this.buttonSaveNewNote.Text = "+1up!";
            this.buttonSaveNewNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveNewNote.UseVisualStyleBackColor = false;
            this.buttonSaveNewNote.Click += new System.EventHandler(this.ButtonSaveNewNote_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(577, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 23);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "×";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(612, 443);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxTags);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scintillaNew);
            this.Controls.Add(this.buttonSaveNewNote);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveNewNote;
        private ScintillaNET.Scintilla scintillaNew;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ComboBox comboBoxTags;
        private System.Windows.Forms.Button buttonClose;
    }
}