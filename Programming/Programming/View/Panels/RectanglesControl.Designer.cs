
namespace Programming.View.Panels
{
	partial class RectanglesControl
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
			this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
			this.IdLabel = new System.Windows.Forms.Label();
			this.IdTextBox = new System.Windows.Forms.TextBox();
			this.YLabel = new System.Windows.Forms.Label();
			this.YTextBox = new System.Windows.Forms.TextBox();
			this.XLabel = new System.Windows.Forms.Label();
			this.XTextBox = new System.Windows.Forms.TextBox();
			this.FindButton = new System.Windows.Forms.Button();
			this.ColorLabel = new System.Windows.Forms.Label();
			this.ColorTextBox = new System.Windows.Forms.TextBox();
			this.WidthLabel = new System.Windows.Forms.Label();
			this.WidthTextBox = new System.Windows.Forms.TextBox();
			this.LengthLabel = new System.Windows.Forms.Label();
			this.LengthTextBox = new System.Windows.Forms.TextBox();
			this.RectanglesListBox = new System.Windows.Forms.ListBox();
			this.RectanglesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// RectanglesGroupBox
			// 
			this.RectanglesGroupBox.Controls.Add(this.IdLabel);
			this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
			this.RectanglesGroupBox.Controls.Add(this.YLabel);
			this.RectanglesGroupBox.Controls.Add(this.YTextBox);
			this.RectanglesGroupBox.Controls.Add(this.XLabel);
			this.RectanglesGroupBox.Controls.Add(this.XTextBox);
			this.RectanglesGroupBox.Controls.Add(this.FindButton);
			this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
			this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
			this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
			this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
			this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
			this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
			this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
			this.RectanglesGroupBox.Location = new System.Drawing.Point(2, 2);
			this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.RectanglesGroupBox.Name = "RectanglesGroupBox";
			this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.RectanglesGroupBox.Size = new System.Drawing.Size(237, 329);
			this.RectanglesGroupBox.TabIndex = 9;
			this.RectanglesGroupBox.TabStop = false;
			this.RectanglesGroupBox.Text = "Rectangles";
			// 
			// IdLabel
			// 
			this.IdLabel.Location = new System.Drawing.Point(135, 223);
			this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new System.Drawing.Size(89, 15);
			this.IdLabel.TabIndex = 13;
			this.IdLabel.Text = "Id:";
			// 
			// IdTextBox
			// 
			this.IdTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.IdTextBox.Enabled = false;
			this.IdTextBox.Location = new System.Drawing.Point(135, 240);
			this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.IdTextBox.Name = "IdTextBox";
			this.IdTextBox.ReadOnly = true;
			this.IdTextBox.Size = new System.Drawing.Size(90, 20);
			this.IdTextBox.TabIndex = 12;
			// 
			// YLabel
			// 
			this.YLabel.Location = new System.Drawing.Point(136, 181);
			this.YLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.YLabel.Name = "YLabel";
			this.YLabel.Size = new System.Drawing.Size(89, 15);
			this.YLabel.TabIndex = 11;
			this.YLabel.Text = "Y:";
			// 
			// YTextBox
			// 
			this.YTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.YTextBox.Enabled = false;
			this.YTextBox.Location = new System.Drawing.Point(136, 198);
			this.YTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.YTextBox.Name = "YTextBox";
			this.YTextBox.ReadOnly = true;
			this.YTextBox.Size = new System.Drawing.Size(90, 20);
			this.YTextBox.TabIndex = 10;
			// 
			// XLabel
			// 
			this.XLabel.Location = new System.Drawing.Point(136, 140);
			this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.XLabel.Name = "XLabel";
			this.XLabel.Size = new System.Drawing.Size(90, 15);
			this.XLabel.TabIndex = 9;
			this.XLabel.Text = "X:";
			// 
			// XTextBox
			// 
			this.XTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.XTextBox.Enabled = false;
			this.XTextBox.Location = new System.Drawing.Point(136, 157);
			this.XTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.XTextBox.Name = "XTextBox";
			this.XTextBox.ReadOnly = true;
			this.XTextBox.Size = new System.Drawing.Size(90, 20);
			this.XTextBox.TabIndex = 8;
			// 
			// FindButton
			// 
			this.FindButton.Location = new System.Drawing.Point(136, 300);
			this.FindButton.Margin = new System.Windows.Forms.Padding(2);
			this.FindButton.Name = "FindButton";
			this.FindButton.Size = new System.Drawing.Size(90, 20);
			this.FindButton.TabIndex = 7;
			this.FindButton.Text = "Find";
			this.FindButton.UseVisualStyleBackColor = true;
			this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
			// 
			// ColorLabel
			// 
			this.ColorLabel.Location = new System.Drawing.Point(135, 98);
			this.ColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ColorLabel.Name = "ColorLabel";
			this.ColorLabel.Size = new System.Drawing.Size(57, 16);
			this.ColorLabel.TabIndex = 6;
			this.ColorLabel.Text = "Color:";
			// 
			// ColorTextBox
			// 
			this.ColorTextBox.Location = new System.Drawing.Point(136, 115);
			this.ColorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ColorTextBox.Name = "ColorTextBox";
			this.ColorTextBox.Size = new System.Drawing.Size(90, 20);
			this.ColorTextBox.TabIndex = 5;
			// 
			// WidthLabel
			// 
			this.WidthLabel.Location = new System.Drawing.Point(136, 58);
			this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WidthLabel.Name = "WidthLabel";
			this.WidthLabel.Size = new System.Drawing.Size(56, 13);
			this.WidthLabel.TabIndex = 4;
			this.WidthLabel.Text = "Width:";
			// 
			// WidthTextBox
			// 
			this.WidthTextBox.Location = new System.Drawing.Point(136, 74);
			this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.WidthTextBox.Name = "WidthTextBox";
			this.WidthTextBox.Size = new System.Drawing.Size(90, 20);
			this.WidthTextBox.TabIndex = 3;
			// 
			// LengthLabel
			// 
			this.LengthLabel.Location = new System.Drawing.Point(136, 18);
			this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LengthLabel.Name = "LengthLabel";
			this.LengthLabel.Size = new System.Drawing.Size(57, 15);
			this.LengthLabel.TabIndex = 2;
			this.LengthLabel.Text = "Length:";
			// 
			// LengthTextBox
			// 
			this.LengthTextBox.Location = new System.Drawing.Point(136, 35);
			this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.LengthTextBox.Name = "LengthTextBox";
			this.LengthTextBox.Size = new System.Drawing.Size(90, 20);
			this.LengthTextBox.TabIndex = 1;
			// 
			// RectanglesListBox
			// 
			this.RectanglesListBox.FormattingEnabled = true;
			this.RectanglesListBox.Location = new System.Drawing.Point(4, 17);
			this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
			this.RectanglesListBox.Name = "RectanglesListBox";
			this.RectanglesListBox.Size = new System.Drawing.Size(128, 303);
			this.RectanglesListBox.TabIndex = 0;
			this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
			// 
			// Rectangles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RectanglesGroupBox);
			this.Name = "RectanglesControl";
			this.Size = new System.Drawing.Size(241, 332);
			this.RectanglesGroupBox.ResumeLayout(false);
			this.RectanglesGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox RectanglesGroupBox;
		private System.Windows.Forms.Label IdLabel;
		private System.Windows.Forms.TextBox IdTextBox;
		private System.Windows.Forms.Label YLabel;
		private System.Windows.Forms.TextBox YTextBox;
		private System.Windows.Forms.Label XLabel;
		private System.Windows.Forms.TextBox XTextBox;
		private System.Windows.Forms.Button FindButton;
		private System.Windows.Forms.Label ColorLabel;
		private System.Windows.Forms.TextBox ColorTextBox;
		private System.Windows.Forms.Label WidthLabel;
		private System.Windows.Forms.TextBox WidthTextBox;
		private System.Windows.Forms.Label LengthLabel;
		private System.Windows.Forms.TextBox LengthTextBox;
		private System.Windows.Forms.ListBox RectanglesListBox;
	}
}
