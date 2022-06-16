
namespace Notes.View.Panels
{
	partial class NotesControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NoteInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.TextOfNoteRichTextBox = new System.Windows.Forms.TextBox();
			this.DateLabel = new System.Windows.Forms.Label();
			this.TextOfNoteLabel = new System.Windows.Forms.Label();
			this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NameOfNoteTextBox = new System.Windows.Forms.TextBox();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.NameOfNoteLabel = new System.Windows.Forms.Label();
			this.NotesLabel = new System.Windows.Forms.Label();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.DeleteNoteButton = new System.Windows.Forms.Button();
			this.AddNoteButton = new System.Windows.Forms.Button();
			this.NoteInfoGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// NoteInfoGroupBox
			// 
			this.NoteInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteInfoGroupBox.Controls.Add(this.TextOfNoteRichTextBox);
			this.NoteInfoGroupBox.Controls.Add(this.DateLabel);
			this.NoteInfoGroupBox.Controls.Add(this.TextOfNoteLabel);
			this.NoteInfoGroupBox.Controls.Add(this.NoteCategoryComboBox);
			this.NoteInfoGroupBox.Controls.Add(this.NameOfNoteTextBox);
			this.NoteInfoGroupBox.Controls.Add(this.NoteCategoryLabel);
			this.NoteInfoGroupBox.Controls.Add(this.NameOfNoteLabel);
			this.NoteInfoGroupBox.Location = new System.Drawing.Point(331, 41);
			this.NoteInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.NoteInfoGroupBox.Name = "NoteInfoGroupBox";
			this.NoteInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.NoteInfoGroupBox.Size = new System.Drawing.Size(456, 564);
			this.NoteInfoGroupBox.TabIndex = 7;
			this.NoteInfoGroupBox.TabStop = false;
			this.NoteInfoGroupBox.Text = "Информация о заметке";
			// 
			// TextOfNoteRichTextBox
			// 
			this.TextOfNoteRichTextBox.Location = new System.Drawing.Point(8, 117);
			this.TextOfNoteRichTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.TextOfNoteRichTextBox.Multiline = true;
			this.TextOfNoteRichTextBox.Name = "TextOfNoteRichTextBox";
			this.TextOfNoteRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextOfNoteRichTextBox.Size = new System.Drawing.Size(440, 439);
			this.TextOfNoteRichTextBox.TabIndex = 7;
			this.TextOfNoteRichTextBox.TextChanged += new System.EventHandler(this.TextOfNoteRichTextBox_TextChanged);
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Location = new System.Drawing.Point(11, 511);
			this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(0, 17);
			this.DateLabel.TabIndex = 6;
			// 
			// TextOfNoteLabel
			// 
			this.TextOfNoteLabel.AutoSize = true;
			this.TextOfNoteLabel.Location = new System.Drawing.Point(193, 96);
			this.TextOfNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TextOfNoteLabel.Name = "TextOfNoteLabel";
			this.TextOfNoteLabel.Size = new System.Drawing.Size(64, 17);
			this.TextOfNoteLabel.TabIndex = 5;
			this.TextOfNoteLabel.Text = "Заметка";
			// 
			// NoteCategoryComboBox
			// 
			this.NoteCategoryComboBox.FormattingEnabled = true;
			this.NoteCategoryComboBox.Location = new System.Drawing.Point(156, 58);
			this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
			this.NoteCategoryComboBox.Size = new System.Drawing.Size(291, 24);
			this.NoteCategoryComboBox.TabIndex = 3;
			this.NoteCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.NoteCategoryComboBox_SelectedValueChanged);
			// 
			// NameOfNoteTextBox
			// 
			this.NameOfNoteTextBox.Location = new System.Drawing.Point(156, 28);
			this.NameOfNoteTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.NameOfNoteTextBox.Name = "NameOfNoteTextBox";
			this.NameOfNoteTextBox.Size = new System.Drawing.Size(291, 22);
			this.NameOfNoteTextBox.TabIndex = 2;
			this.NameOfNoteTextBox.TextChanged += new System.EventHandler(this.NameOfNoteTextBox_TextChanged);
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(15, 65);
			this.NoteCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(81, 17);
			this.NoteCategoryLabel.TabIndex = 1;
			this.NoteCategoryLabel.Text = "Категория:";
			// 
			// NameOfNoteLabel
			// 
			this.NameOfNoteLabel.AutoSize = true;
			this.NameOfNoteLabel.Location = new System.Drawing.Point(15, 31);
			this.NameOfNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameOfNoteLabel.Name = "NameOfNoteLabel";
			this.NameOfNoteLabel.Size = new System.Drawing.Size(134, 17);
			this.NameOfNoteLabel.TabIndex = 0;
			this.NameOfNoteLabel.Text = "Название заметки:";
			// 
			// NotesLabel
			// 
			this.NotesLabel.AutoSize = true;
			this.NotesLabel.Location = new System.Drawing.Point(17, 20);
			this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NotesLabel.Name = "NotesLabel";
			this.NotesLabel.Size = new System.Drawing.Size(113, 17);
			this.NotesLabel.TabIndex = 6;
			this.NotesLabel.Text = "Список заметок";
			// 
			// NotesListBox
			// 
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.ItemHeight = 16;
			this.NotesListBox.Location = new System.Drawing.Point(17, 41);
			this.NotesListBox.Margin = new System.Windows.Forms.Padding(4);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(267, 500);
			this.NotesListBox.TabIndex = 5;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			this.NotesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotesListBox_MouseDoubleClick);
			// 
			// DeleteNoteButton
			// 
			this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.DeleteNoteButton.Image = global::Notes.Properties.Resources.Note_Remove_Uncolor;
			this.DeleteNoteButton.Location = new System.Drawing.Point(233, 544);
			this.DeleteNoteButton.Margin = new System.Windows.Forms.Padding(4);
			this.DeleteNoteButton.Name = "DeleteNoteButton";
			this.DeleteNoteButton.Size = new System.Drawing.Size(51, 43);
			this.DeleteNoteButton.TabIndex = 9;
			this.DeleteNoteButton.UseVisualStyleBackColor = true;
			this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
			this.DeleteNoteButton.MouseLeave += new System.EventHandler(this.DeleteNoteButton_MouseLeave);
			this.DeleteNoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteNoteButton_MouseMove);
			// 
			// AddNoteButton
			// 
			this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNoteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.AddNoteButton.Location = new System.Drawing.Point(199, 544);
			this.AddNoteButton.Margin = new System.Windows.Forms.Padding(4);
			this.AddNoteButton.Name = "AddNoteButton";
			this.AddNoteButton.Size = new System.Drawing.Size(43, 43);
			this.AddNoteButton.TabIndex = 8;
			this.AddNoteButton.UseVisualStyleBackColor = true;
			this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
			this.AddNoteButton.MouseLeave += new System.EventHandler(this.AddNoteButton_MouseLeave);
			this.AddNoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNoteButton_MouseMove);
			// 
			// NotesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.DeleteNoteButton);
			this.Controls.Add(this.AddNoteButton);
			this.Controls.Add(this.NoteInfoGroupBox);
			this.Controls.Add(this.NotesLabel);
			this.Controls.Add(this.NotesListBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(804, 628);
			this.Name = "NotesControl";
			this.Size = new System.Drawing.Size(804, 628);
			this.NoteInfoGroupBox.ResumeLayout(false);
			this.NoteInfoGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button DeleteNoteButton;
		private System.Windows.Forms.Button AddNoteButton;
		private System.Windows.Forms.GroupBox NoteInfoGroupBox;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label TextOfNoteLabel;
		private System.Windows.Forms.ComboBox NoteCategoryComboBox;
		private System.Windows.Forms.TextBox NameOfNoteTextBox;
		private System.Windows.Forms.Label NoteCategoryLabel;
		private System.Windows.Forms.Label NameOfNoteLabel;
		private System.Windows.Forms.Label NotesLabel;
		private System.Windows.Forms.ListBox NotesListBox;
		private System.Windows.Forms.TextBox TextOfNoteRichTextBox;
	}
}
