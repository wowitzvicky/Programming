namespace Programming.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
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
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ParseInfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.TabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(661, 454);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 425);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FindFilmButton);
            this.groupBox5.Controls.Add(this.RatingLabel);
            this.groupBox5.Controls.Add(this.RatingTextBox);
            this.groupBox5.Controls.Add(this.YearLabel);
            this.groupBox5.Controls.Add(this.YearTextBox);
            this.groupBox5.Controls.Add(this.DurationLabel);
            this.groupBox5.Controls.Add(this.DurationTextBox);
            this.groupBox5.Controls.Add(this.GenreLabel);
            this.groupBox5.Controls.Add(this.GenreTextBox);
            this.groupBox5.Controls.Add(this.TitleLabel);
            this.groupBox5.Controls.Add(this.TitleTextBox);
            this.groupBox5.Controls.Add(this.FilmsListBox);
            this.groupBox5.Location = new System.Drawing.Point(330, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 405);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Films";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(181, 368);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(120, 25);
            this.FindFilmButton.TabIndex = 18;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Location = new System.Drawing.Point(181, 213);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(119, 18);
            this.RatingLabel.TabIndex = 17;
            this.RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(181, 234);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(120, 22);
            this.RatingTextBox.TabIndex = 16;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.Location = new System.Drawing.Point(181, 165);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(119, 18);
            this.YearLabel.TabIndex = 15;
            this.YearLabel.Text = "Year of release:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(181, 186);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(120, 22);
            this.YearTextBox.TabIndex = 14;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.Location = new System.Drawing.Point(181, 116);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(119, 20);
            this.DurationLabel.TabIndex = 13;
            this.DurationLabel.Text = "Duration:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(181, 139);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(120, 22);
            this.DurationTextBox.TabIndex = 12;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.Location = new System.Drawing.Point(181, 70);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(119, 18);
            this.GenreLabel.TabIndex = 11;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(181, 91);
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
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(120, 22);
            this.TitleTextBox.TabIndex = 8;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 16;
            this.FilmsListBox.Location = new System.Drawing.Point(6, 21);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(169, 372);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FindButton);
            this.groupBox4.Controls.Add(this.ColorLabel);
            this.groupBox4.Controls.Add(this.ColorTextBox);
            this.groupBox4.Controls.Add(this.WidthLabel);
            this.groupBox4.Controls.Add(this.WidthTextBox);
            this.groupBox4.Controls.Add(this.LengthLabel);
            this.groupBox4.Controls.Add(this.LengthTextBox);
            this.groupBox4.Controls.Add(this.RectanglesListBox);
            this.groupBox4.Location = new System.Drawing.Point(8, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 405);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rectangles";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(181, 368);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(120, 25);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(182, 116);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(76, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(182, 139);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(119, 22);
            this.ColorTextBox.TabIndex = 5;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(182, 68);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(75, 20);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(182, 91);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(119, 22);
            this.WidthTextBox.TabIndex = 3;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.Location = new System.Drawing.Point(182, 21);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(76, 19);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Length:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(182, 43);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(119, 22);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 21);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(169, 372);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(653, 425);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Enums";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GoButton);
            this.GroupBox3.Controls.Add(this.ChooseLabel);
            this.GroupBox3.Controls.Add(this.SeasonComboBox);
            this.GroupBox3.Location = new System.Drawing.Point(441, 277);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(198, 144);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(118, 40);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(74, 25);
            this.GoButton.TabIndex = 13;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.Location = new System.Drawing.Point(6, 18);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(118, 22);
            this.ChooseLabel.TabIndex = 12;
            this.ChooseLabel.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 40);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(106, 24);
            this.SeasonComboBox.TabIndex = 11;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ParseInfoLabel);
            this.GroupBox2.Controls.Add(this.InfoLabel);
            this.GroupBox2.Controls.Add(this.ParseButton);
            this.GroupBox2.Controls.Add(this.ParseTextBox);
            this.GroupBox2.Location = new System.Drawing.Point(8, 277);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(427, 144);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Weekday Parsing";
            // 
            // ParseInfoLabel
            // 
            this.ParseInfoLabel.Location = new System.Drawing.Point(6, 68);
            this.ParseInfoLabel.Name = "ParseInfoLabel";
            this.ParseInfoLabel.Size = new System.Drawing.Size(244, 68);
            this.ParseInfoLabel.TabIndex = 11;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(6, 18);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(163, 22);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(174, 40);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 25);
            this.ParseButton.TabIndex = 9;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(7, 40);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(162, 22);
            this.ParseTextBox.TabIndex = 8;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.IntValueTextBox);
            this.GroupBox1.Controls.Add(this.IntValueLabel);
            this.GroupBox1.Controls.Add(this.ChooseValueLabel);
            this.GroupBox1.Controls.Add(this.ChooseEnumLabel);
            this.GroupBox1.Controls.Add(this.ValuesListBox);
            this.GroupBox1.Controls.Add(this.EnumsListBox);
            this.GroupBox1.Location = new System.Drawing.Point(8, 16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(427, 255);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(344, 37);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(77, 22);
            this.IntValueTextBox.TabIndex = 6;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.Location = new System.Drawing.Point(344, 18);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(77, 16);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int Value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.Location = new System.Drawing.Point(174, 18);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(162, 16);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.Location = new System.Drawing.Point(6, 18);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(162, 16);
            this.ChooseEnumLabel.TabIndex = 3;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(175, 37);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(163, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 37);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(163, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 454);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Enumerations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FindFilmButton;

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

        private System.Windows.Forms.ListBox FilmsListBox;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.Button FindButton;

        private System.Windows.Forms.Label ColorLabel;

        private System.Windows.Forms.TextBox ColorTextBox;

        private System.Windows.Forms.Label WidthLabel;

        private System.Windows.Forms.TextBox WidthTextBox;

        private System.Windows.Forms.Label LengthLabel;

        private System.Windows.Forms.TextBox LengthTextBox;

        private System.Windows.Forms.ListBox RectanglesListBox;

        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.GroupBox GroupBox3;

        private System.Windows.Forms.Label ChooseLabel;

        private System.Windows.Forms.ComboBox SeasonComboBox;

        private System.Windows.Forms.Label ParseInfoLabel;

        private System.Windows.Forms.Label InfoLabel;

        private System.Windows.Forms.GroupBox GroupBox2;

        private System.Windows.Forms.Button ParseButton;

        private System.Windows.Forms.TextBox ParseTextBox;

        private System.Windows.Forms.GroupBox GroupBox1;

        private System.Windows.Forms.TextBox IntValueTextBox;

        private System.Windows.Forms.Label IntValueLabel;

        private System.Windows.Forms.Label ChooseValueLabel;

        private System.Windows.Forms.Label ChooseEnumLabel;

        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;

        #endregion
    }
}