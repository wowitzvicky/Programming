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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParseInfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.parseBtn = new System.Windows.Forms.Button();
            this.parseTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GoBtn);
            this.groupBox3.Controls.Add(this.chooseLabel);
            this.groupBox3.Controls.Add(this.SeasonComboBox);
            this.groupBox3.Location = new System.Drawing.Point(493, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 195);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(186, 53);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(77, 24);
            this.GoBtn.TabIndex = 13;
            this.GoBtn.Text = "Go!";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.Location = new System.Drawing.Point(41, 28);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(118, 22);
            this.chooseLabel.TabIndex = 12;
            this.chooseLabel.Text = "Choose season:";
            // 
            // seasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(41, 53);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(106, 24);
            this.SeasonComboBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParseInfoLabel);
            this.groupBox2.Controls.Add(this.InfoLabel);
            this.groupBox2.Controls.Add(this.parseBtn);
            this.groupBox2.Controls.Add(this.parseTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 196);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // ParseInfoLabel
            // 
            this.ParseInfoLabel.Location = new System.Drawing.Point(14, 113);
            this.ParseInfoLabel.Name = "ParseInfoLabel";
            this.ParseInfoLabel.Size = new System.Drawing.Size(267, 66);
            this.ParseInfoLabel.TabIndex = 11;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(14, 33);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(162, 22);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "Type value for parsing:";
            // 
            // parseBtn
            // 
            this.parseBtn.Location = new System.Drawing.Point(200, 58);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(93, 22);
            this.parseBtn.TabIndex = 9;
            this.parseBtn.Text = "Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // parseTextBox
            // 
            this.parseTextBox.Location = new System.Drawing.Point(14, 58);
            this.parseTextBox.Name = "parseTextBox";
            this.parseTextBox.Size = new System.Drawing.Size(147, 22);
            this.parseTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntValueTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 272);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(454, 34);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(77, 22);
            this.IntValueTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(454, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int Value:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(201, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(200, 34);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(163, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(14, 34);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(163, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Enumerations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Label chooseLabel;

        private System.Windows.Forms.ComboBox SeasonComboBox;

        private System.Windows.Forms.Label ParseInfoLabel;

        private System.Windows.Forms.Label InfoLabel;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button parseBtn;

        private System.Windows.Forms.TextBox parseTextBox;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox IntValueTextBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        #endregion
    }
}