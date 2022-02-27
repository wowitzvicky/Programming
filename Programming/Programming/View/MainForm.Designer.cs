namespace Programming1
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
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(654, 457);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(646, 428);
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
            this.GoButton.Size = new System.Drawing.Size(73, 24);
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
            this.ParseButton.Location = new System.Drawing.Point(175, 40);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 22);
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
            this.ClientSize = new System.Drawing.Size(654, 457);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Enumerations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

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