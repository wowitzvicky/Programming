﻿
namespace Programming.View.Panels
{
	partial class WeekdayParsingControl
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
			this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
			this.ParseInfoLabel = new System.Windows.Forms.Label();
			this.InfoLabel = new System.Windows.Forms.Label();
			this.ParseButton = new System.Windows.Forms.Button();
			this.ParseTextBox = new System.Windows.Forms.TextBox();
			this.WeekdayParsingGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// WeekdayParsingGroupBox
			// 
			this.WeekdayParsingGroupBox.Controls.Add(this.ParseInfoLabel);
			this.WeekdayParsingGroupBox.Controls.Add(this.InfoLabel);
			this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
			this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
			this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(2, 2);
			this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
			this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(320, 117);
			this.WeekdayParsingGroupBox.TabIndex = 11;
			this.WeekdayParsingGroupBox.TabStop = false;
			this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
			// 
			// ParseInfoLabel
			// 
			this.ParseInfoLabel.Location = new System.Drawing.Point(4, 58);
			this.ParseInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ParseInfoLabel.Name = "ParseInfoLabel";
			this.ParseInfoLabel.Size = new System.Drawing.Size(182, 52);
			this.ParseInfoLabel.TabIndex = 11;
			// 
			// InfoLabel
			// 
			this.InfoLabel.Location = new System.Drawing.Point(4, 15);
			this.InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(122, 18);
			this.InfoLabel.TabIndex = 10;
			this.InfoLabel.Text = "Type value for parsing:";
			// 
			// ParseButton
			// 
			this.ParseButton.Location = new System.Drawing.Point(130, 36);
			this.ParseButton.Margin = new System.Windows.Forms.Padding(2);
			this.ParseButton.Name = "ParseButton";
			this.ParseButton.Size = new System.Drawing.Size(56, 20);
			this.ParseButton.TabIndex = 9;
			this.ParseButton.Text = "Parse";
			this.ParseButton.UseVisualStyleBackColor = true;
			this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
			// 
			// ParseTextBox
			// 
			this.ParseTextBox.Location = new System.Drawing.Point(5, 36);
			this.ParseTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ParseTextBox.Name = "ParseTextBox";
			this.ParseTextBox.Size = new System.Drawing.Size(122, 20);
			this.ParseTextBox.TabIndex = 8;
			// 
			// Parsing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.WeekdayParsingGroupBox);
			this.Name = "WeekdayParsingControl";
			this.Size = new System.Drawing.Size(326, 122);
			this.WeekdayParsingGroupBox.ResumeLayout(false);
			this.WeekdayParsingGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
		private System.Windows.Forms.Label ParseInfoLabel;
		private System.Windows.Forms.Label InfoLabel;
		private System.Windows.Forms.Button ParseButton;
		private System.Windows.Forms.TextBox ParseTextBox;
	}
}
