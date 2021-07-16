
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.scintillaNew = new ScintillaNET.Scintilla();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveNewNote = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxTags);
            this.groupBox1.Controls.Add(this.comboBoxCategories);
            this.groupBox1.Controls.Add(this.scintillaNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSaveNewNote);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Note";
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.FormattingEnabled = true;
            this.comboBoxTags.Location = new System.Drawing.Point(134, 40);
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTags.TabIndex = 8;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(7, 40);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategories.TabIndex = 7;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.Update_Tags);
            // 
            // scintillaNew
            // 
            this.scintillaNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaNew.AutoCMaxHeight = 9;
            this.scintillaNew.EndAtLastLine = false;
            this.scintillaNew.Location = new System.Drawing.Point(7, 70);
            this.scintillaNew.Name = "scintillaNew";
            this.scintillaNew.Size = new System.Drawing.Size(762, 320);
            this.scintillaNew.TabIndex = 6;
            this.scintillaNew.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.Scintilla_CharAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "#Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // buttonSaveNewNote
            // 
            this.buttonSaveNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveNewNote.Location = new System.Drawing.Point(7, 396);
            this.buttonSaveNewNote.Name = "buttonSaveNewNote";
            this.buttonSaveNewNote.Size = new System.Drawing.Size(762, 23);
            this.buttonSaveNewNote.TabIndex = 3;
            this.buttonSaveNewNote.Text = "+1up!";
            this.buttonSaveNewNote.UseVisualStyleBackColor = true;
            this.buttonSaveNewNote.Click += new System.EventHandler(this.ButtonSaveNewNote_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveNewNote;
        private ScintillaNET.Scintilla scintillaNew;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ComboBox comboBoxTags;
    }
}