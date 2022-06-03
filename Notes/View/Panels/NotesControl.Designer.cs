
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.NoteInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.DateLabel = new System.Windows.Forms.Label();
			this.TextOfNoteLabel = new System.Windows.Forms.Label();
			this.TextOfNoteRichTextBox = new System.Windows.Forms.RichTextBox();
			this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NameOfNoteTextBox = new System.Windows.Forms.TextBox();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.NameOfNoteLabel = new System.Windows.Forms.Label();
			this.NotesLabel = new System.Windows.Forms.Label();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.ChangePushButton = new System.Windows.Forms.Button();
			this.DeleteNoteButton = new System.Windows.Forms.Button();
			this.AddNoteButton = new System.Windows.Forms.Button();
			this.NoteInfoGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// NoteInfoGroupBox
			// 
			this.NoteInfoGroupBox.Controls.Add(this.DateLabel);
			this.NoteInfoGroupBox.Controls.Add(this.TextOfNoteLabel);
			this.NoteInfoGroupBox.Controls.Add(this.TextOfNoteRichTextBox);
			this.NoteInfoGroupBox.Controls.Add(this.NoteCategoryComboBox);
			this.NoteInfoGroupBox.Controls.Add(this.NameOfNoteTextBox);
			this.NoteInfoGroupBox.Controls.Add(this.NoteCategoryLabel);
			this.NoteInfoGroupBox.Controls.Add(this.NameOfNoteLabel);
			this.NoteInfoGroupBox.Location = new System.Drawing.Point(248, 33);
			this.NoteInfoGroupBox.Name = "NoteInfoGroupBox";
			this.NoteInfoGroupBox.Size = new System.Drawing.Size(342, 458);
			this.NoteInfoGroupBox.TabIndex = 7;
			this.NoteInfoGroupBox.TabStop = false;
			this.NoteInfoGroupBox.Text = "Информация о заметке";
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Location = new System.Drawing.Point(8, 415);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(0, 13);
			this.DateLabel.TabIndex = 6;
			// 
			// TextOfNoteLabel
			// 
			this.TextOfNoteLabel.AutoSize = true;
			this.TextOfNoteLabel.Location = new System.Drawing.Point(145, 93);
			this.TextOfNoteLabel.Name = "TextOfNoteLabel";
			this.TextOfNoteLabel.Size = new System.Drawing.Size(51, 13);
			this.TextOfNoteLabel.TabIndex = 5;
			this.TextOfNoteLabel.Text = "Заметка";
			// 
			// TextOfNoteRichTextBox
			// 
			this.TextOfNoteRichTextBox.Location = new System.Drawing.Point(6, 115);
			this.TextOfNoteRichTextBox.Name = "TextOfNoteRichTextBox";
			this.TextOfNoteRichTextBox.Size = new System.Drawing.Size(325, 292);
			this.TextOfNoteRichTextBox.TabIndex = 4;
			this.TextOfNoteRichTextBox.Text = "";
			// 
			// NoteCategoryComboBox
			// 
			this.NoteCategoryComboBox.FormattingEnabled = true;
			this.NoteCategoryComboBox.Location = new System.Drawing.Point(117, 56);
			this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
			this.NoteCategoryComboBox.Size = new System.Drawing.Size(121, 21);
			this.NoteCategoryComboBox.TabIndex = 3;
			// 
			// NameOfNoteTextBox
			// 
			this.NameOfNoteTextBox.Location = new System.Drawing.Point(117, 20);
			this.NameOfNoteTextBox.Name = "NameOfNoteTextBox";
			this.NameOfNoteTextBox.Size = new System.Drawing.Size(219, 20);
			this.NameOfNoteTextBox.TabIndex = 2;
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(8, 56);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(60, 13);
			this.NoteCategoryLabel.TabIndex = 1;
			this.NoteCategoryLabel.Text = "Категория";
			// 
			// NameOfNoteLabel
			// 
			this.NameOfNoteLabel.AutoSize = true;
			this.NameOfNoteLabel.Location = new System.Drawing.Point(8, 23);
			this.NameOfNoteLabel.Name = "NameOfNoteLabel";
			this.NameOfNoteLabel.Size = new System.Drawing.Size(103, 13);
			this.NameOfNoteLabel.TabIndex = 0;
			this.NameOfNoteLabel.Text = "Название заметки";
			// 
			// NotesLabel
			// 
			this.NotesLabel.AutoSize = true;
			this.NotesLabel.Location = new System.Drawing.Point(13, 9);
			this.NotesLabel.Name = "NotesLabel";
			this.NotesLabel.Size = new System.Drawing.Size(90, 13);
			this.NotesLabel.TabIndex = 6;
			this.NotesLabel.Text = "Список заметок";
			// 
			// NotesListBox
			// 
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.Location = new System.Drawing.Point(12, 33);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(201, 407);
			this.NotesListBox.TabIndex = 5;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			// 
			// ChangePushButton
			// 
			this.ChangePushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangePushButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ChangePushButton.Image = global::Notes.Properties.Resources.Note_Change_Uncolor;
			this.ChangePushButton.Location = new System.Drawing.Point(175, 442);
			this.ChangePushButton.Name = "ChangePushButton";
			this.ChangePushButton.Size = new System.Drawing.Size(38, 35);
			this.ChangePushButton.TabIndex = 10;
			this.ChangePushButton.UseVisualStyleBackColor = true;
			this.ChangePushButton.Click += new System.EventHandler(this.ChangePushButton_Click);
			this.ChangePushButton.MouseLeave += new System.EventHandler(this.ChangePushButton_MouseLeave);
			this.ChangePushButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePushButton_MouseMove);
			// 
			// DeleteNoteButton
			// 
			this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.DeleteNoteButton.Image = global::Notes.Properties.Resources.Note_Remove_Uncolor;
			this.DeleteNoteButton.Location = new System.Drawing.Point(131, 442);
			this.DeleteNoteButton.Name = "DeleteNoteButton";
			this.DeleteNoteButton.Size = new System.Drawing.Size(38, 35);
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
			this.AddNoteButton.Image = global::Notes.Properties.Resources.Note_Add_Uncolor_;
			this.AddNoteButton.Location = new System.Drawing.Point(93, 442);
			this.AddNoteButton.Name = "AddNoteButton";
			this.AddNoteButton.Size = new System.Drawing.Size(32, 35);
			this.AddNoteButton.TabIndex = 8;
			this.AddNoteButton.UseVisualStyleBackColor = true;
			this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
			this.AddNoteButton.MouseLeave += new System.EventHandler(this.AddNoteButton_MouseLeave);
			this.AddNoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNoteButton_MouseMove);
			// 
			// NotesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.ChangePushButton);
			this.Controls.Add(this.DeleteNoteButton);
			this.Controls.Add(this.AddNoteButton);
			this.Controls.Add(this.NoteInfoGroupBox);
			this.Controls.Add(this.NotesLabel);
			this.Controls.Add(this.NotesListBox);
			this.MinimumSize = new System.Drawing.Size(603, 510);
			this.Name = "NotesControl";
			this.Size = new System.Drawing.Size(603, 510);
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
		private System.Windows.Forms.RichTextBox TextOfNoteRichTextBox;
		private System.Windows.Forms.ComboBox NoteCategoryComboBox;
		private System.Windows.Forms.TextBox NameOfNoteTextBox;
		private System.Windows.Forms.Label NoteCategoryLabel;
		private System.Windows.Forms.Label NameOfNoteLabel;
		private System.Windows.Forms.Label NotesLabel;
		private System.Windows.Forms.ListBox NotesListBox;
		private System.Windows.Forms.Button ChangePushButton;
	}
}
