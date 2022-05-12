
namespace Programming.View.Panels
{
	partial class MoviesControl
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
			this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
			this.FindMovieButton = new System.Windows.Forms.Button();
			this.RatingLabel = new System.Windows.Forms.Label();
			this.RatingTextBox = new System.Windows.Forms.TextBox();
			this.YearLabel = new System.Windows.Forms.Label();
			this.YearTextBox = new System.Windows.Forms.TextBox();
			this.DurationLabel = new System.Windows.Forms.Label();
			this.DurationTextBox = new System.Windows.Forms.TextBox();
			this.GenreLabel = new System.Windows.Forms.Label();
			this.GenreTextBox = new System.Windows.Forms.TextBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.MoviesListBox = new System.Windows.Forms.ListBox();
			this.MoviesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// MoviesGroupBox
			// 
			this.MoviesGroupBox.Controls.Add(this.FindMovieButton);
			this.MoviesGroupBox.Controls.Add(this.RatingLabel);
			this.MoviesGroupBox.Controls.Add(this.RatingTextBox);
			this.MoviesGroupBox.Controls.Add(this.YearLabel);
			this.MoviesGroupBox.Controls.Add(this.YearTextBox);
			this.MoviesGroupBox.Controls.Add(this.DurationLabel);
			this.MoviesGroupBox.Controls.Add(this.DurationTextBox);
			this.MoviesGroupBox.Controls.Add(this.GenreLabel);
			this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
			this.MoviesGroupBox.Controls.Add(this.TitleLabel);
			this.MoviesGroupBox.Controls.Add(this.TitleTextBox);
			this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
			this.MoviesGroupBox.Location = new System.Drawing.Point(3, 2);
			this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MoviesGroupBox.Name = "MoviesGroupBox";
			this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MoviesGroupBox.Size = new System.Drawing.Size(316, 405);
			this.MoviesGroupBox.TabIndex = 10;
			this.MoviesGroupBox.TabStop = false;
			this.MoviesGroupBox.Text = "Movies";
			// 
			// FindMovieButton
			// 
			this.FindMovieButton.Location = new System.Drawing.Point(181, 369);
			this.FindMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FindMovieButton.Name = "FindMovieButton";
			this.FindMovieButton.Size = new System.Drawing.Size(120, 25);
			this.FindMovieButton.TabIndex = 18;
			this.FindMovieButton.Text = "Find";
			this.FindMovieButton.UseVisualStyleBackColor = true;
			this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
			// 
			// RatingLabel
			// 
			this.RatingLabel.Location = new System.Drawing.Point(181, 223);
			this.RatingLabel.Name = "RatingLabel";
			this.RatingLabel.Size = new System.Drawing.Size(119, 18);
			this.RatingLabel.TabIndex = 17;
			this.RatingLabel.Text = "Rating:";
			// 
			// RatingTextBox
			// 
			this.RatingTextBox.Location = new System.Drawing.Point(181, 244);
			this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RatingTextBox.Name = "RatingTextBox";
			this.RatingTextBox.Size = new System.Drawing.Size(120, 22);
			this.RatingTextBox.TabIndex = 16;
			this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
			// 
			// YearLabel
			// 
			this.YearLabel.Location = new System.Drawing.Point(180, 172);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(119, 18);
			this.YearLabel.TabIndex = 15;
			this.YearLabel.Text = "Year of release:";
			// 
			// YearTextBox
			// 
			this.YearTextBox.Location = new System.Drawing.Point(181, 193);
			this.YearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.YearTextBox.Name = "YearTextBox";
			this.YearTextBox.Size = new System.Drawing.Size(120, 22);
			this.YearTextBox.TabIndex = 14;
			this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
			// 
			// DurationLabel
			// 
			this.DurationLabel.Location = new System.Drawing.Point(180, 121);
			this.DurationLabel.Name = "DurationLabel";
			this.DurationLabel.Size = new System.Drawing.Size(119, 20);
			this.DurationLabel.TabIndex = 13;
			this.DurationLabel.Text = "Duration:";
			// 
			// DurationTextBox
			// 
			this.DurationTextBox.Location = new System.Drawing.Point(181, 142);
			this.DurationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DurationTextBox.Name = "DurationTextBox";
			this.DurationTextBox.Size = new System.Drawing.Size(120, 22);
			this.DurationTextBox.TabIndex = 12;
			this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
			// 
			// GenreLabel
			// 
			this.GenreLabel.Location = new System.Drawing.Point(181, 71);
			this.GenreLabel.Name = "GenreLabel";
			this.GenreLabel.Size = new System.Drawing.Size(119, 18);
			this.GenreLabel.TabIndex = 11;
			this.GenreLabel.Text = "Genre:";
			// 
			// GenreTextBox
			// 
			this.GenreTextBox.Location = new System.Drawing.Point(181, 91);
			this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GenreTextBox.Name = "GenreTextBox";
			this.GenreTextBox.Size = new System.Drawing.Size(120, 22);
			this.GenreTextBox.TabIndex = 10;
			this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
			// 
			// TitleLabel
			// 
			this.TitleLabel.Location = new System.Drawing.Point(181, 22);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(119, 18);
			this.TitleLabel.TabIndex = 9;
			this.TitleLabel.Text = "Title:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Location = new System.Drawing.Point(181, 43);
			this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(120, 22);
			this.TitleTextBox.TabIndex = 8;
			this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
			// 
			// MoviesListBox
			// 
			this.MoviesListBox.FormattingEnabled = true;
			this.MoviesListBox.ItemHeight = 16;
			this.MoviesListBox.Location = new System.Drawing.Point(5, 21);
			this.MoviesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MoviesListBox.Name = "MoviesListBox";
			this.MoviesListBox.Size = new System.Drawing.Size(169, 372);
			this.MoviesListBox.TabIndex = 0;
			this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
			// 
			// MoviesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MoviesGroupBox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MoviesControl";
			this.Size = new System.Drawing.Size(323, 411);
			this.MoviesGroupBox.ResumeLayout(false);
			this.MoviesGroupBox.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox MoviesGroupBox;
		private System.Windows.Forms.Button FindMovieButton;
		private System.Windows.Forms.Label RatingLabel;
		private System.Windows.Forms.TextBox RatingTextBox;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.TextBox YearTextBox;
		private System.Windows.Forms.Label DurationLabel;
		private System.Windows.Forms.TextBox DurationTextBox;
		private System.Windows.Forms.Label GenreLabel;
		private System.Windows.Forms.TextBox GenreTextBox;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.ListBox MoviesListBox;
	}
}
