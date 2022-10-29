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
	        this.TabControl = new System.Windows.Forms.TabControl();
	        this.ClassesTabPage = new System.Windows.Forms.TabPage();
	        this.movies1 = new Programming.View.Panels.MoviesControl();
	        this.rectangles1 = new Programming.View.Panels.RectanglesControl();
	        this.EnumerationsTabPage = new System.Windows.Forms.TabPage();
	        this.enumerations1 = new Programming.View.Panels.EnumerationsControl();
	        this.seasonHandle1 = new Programming.View.Panels.SeasonHandleControl();
	        this.parsing1 = new Programming.View.Panels.WeekdayParsingControl();
	        this.RectanglesTabPage = new System.Windows.Forms.TabPage();
	        this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
	        this.TabControl.SuspendLayout();
	        this.ClassesTabPage.SuspendLayout();
	        this.EnumerationsTabPage.SuspendLayout();
	        this.RectanglesTabPage.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // TabControl
	        // 
	        this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.TabControl.Controls.Add(this.ClassesTabPage);
	        this.TabControl.Controls.Add(this.EnumerationsTabPage);
	        this.TabControl.Controls.Add(this.RectanglesTabPage);
	        this.TabControl.Location = new System.Drawing.Point(0, 0);
	        this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.TabControl.Name = "TabControl";
	        this.TabControl.SelectedIndex = 0;
	        this.TabControl.Size = new System.Drawing.Size(695, 492);
	        this.TabControl.TabIndex = 0;
	        // 
	        // ClassesTabPage
	        // 
	        this.ClassesTabPage.Controls.Add(this.movies1);
	        this.ClassesTabPage.Controls.Add(this.rectangles1);
	        this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
	        this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.ClassesTabPage.Name = "ClassesTabPage";
	        this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.ClassesTabPage.Size = new System.Drawing.Size(687, 463);
	        this.ClassesTabPage.TabIndex = 0;
	        this.ClassesTabPage.Text = "Classes";
	        this.ClassesTabPage.UseVisualStyleBackColor = true;
	        // 
	        // movies1
	        // 
	        this.movies1.Location = new System.Drawing.Point(349, 11);
	        this.movies1.Margin = new System.Windows.Forms.Padding(5);
	        this.movies1.Name = "movies1";
	        this.movies1.Size = new System.Drawing.Size(323, 411);
	        this.movies1.TabIndex = 11;
	        // 
	        // rectangles1
	        // 
	        this.rectangles1.Location = new System.Drawing.Point(7, 11);
	        this.rectangles1.Margin = new System.Windows.Forms.Padding(5);
	        this.rectangles1.Name = "rectangles1";
	        this.rectangles1.Size = new System.Drawing.Size(321, 409);
	        this.rectangles1.TabIndex = 10;
	        // 
	        // EnumerationsTabPage
	        // 
	        this.EnumerationsTabPage.Controls.Add(this.enumerations1);
	        this.EnumerationsTabPage.Controls.Add(this.seasonHandle1);
	        this.EnumerationsTabPage.Controls.Add(this.parsing1);
	        this.EnumerationsTabPage.Location = new System.Drawing.Point(4, 25);
	        this.EnumerationsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.EnumerationsTabPage.Name = "EnumerationsTabPage";
	        this.EnumerationsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.EnumerationsTabPage.Size = new System.Drawing.Size(687, 463);
	        this.EnumerationsTabPage.TabIndex = 0;
	        this.EnumerationsTabPage.Text = "Enums";
	        this.EnumerationsTabPage.UseVisualStyleBackColor = true;
	        // 
	        // enumerations1
	        // 
	        this.enumerations1.Location = new System.Drawing.Point(7, 7);
	        this.enumerations1.Margin = new System.Windows.Forms.Padding(5);
	        this.enumerations1.Name = "enumerations1";
	        this.enumerations1.Size = new System.Drawing.Size(432, 257);
	        this.enumerations1.TabIndex = 17;
	        // 
	        // seasonHandle1
	        // 
	        this.seasonHandle1.Location = new System.Drawing.Point(449, 272);
	        this.seasonHandle1.Margin = new System.Windows.Forms.Padding(5);
	        this.seasonHandle1.Name = "seasonHandle1";
	        this.seasonHandle1.Size = new System.Drawing.Size(204, 150);
	        this.seasonHandle1.TabIndex = 16;
	        // 
	        // parsing1
	        // 
	        this.parsing1.Location = new System.Drawing.Point(7, 272);
	        this.parsing1.Margin = new System.Windows.Forms.Padding(5);
	        this.parsing1.Name = "parsing1";
	        this.parsing1.Size = new System.Drawing.Size(435, 150);
	        this.parsing1.TabIndex = 15;
	        // 
	        // RectanglesTabPage
	        // 
	        this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
	        this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
	        this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.RectanglesTabPage.Name = "RectanglesTabPage";
	        this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.RectanglesTabPage.Size = new System.Drawing.Size(687, 463);
	        this.RectanglesTabPage.TabIndex = 1;
	        this.RectanglesTabPage.Text = "Rectangles";
	        this.RectanglesTabPage.UseVisualStyleBackColor = true;
	        // 
	        // rectanglesCollisionControl1
	        // 
	        this.rectanglesCollisionControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.rectanglesCollisionControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
	        this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 2);
	        this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(5);
	        this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
	        this.rectanglesCollisionControl1.Size = new System.Drawing.Size(681, 459);
	        this.rectanglesCollisionControl1.TabIndex = 0;
	        // 
	        // MainForm
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(695, 492);
	        this.Controls.Add(this.TabControl);
	        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
	        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	        this.Name = "MainForm";
	        this.Text = "Enumerations and classes";
	        this.TabControl.ResumeLayout(false);
	        this.ClassesTabPage.ResumeLayout(false);
	        this.EnumerationsTabPage.ResumeLayout(false);
	        this.RectanglesTabPage.ResumeLayout(false);
	        this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Panel Canva;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TabPage RectanglesTabPage;

        private System.Windows.Forms.TabPage ClassesTabPage;

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumerationsTabPage;

		#endregion

		private Programming.View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
		private Programming.View.Panels.RectanglesControl rectangles1;
		private Panels.MoviesControl movies1;
		private Programming.View.Panels.WeekdayParsingControl parsing1;
		private Panels.SeasonHandleControl seasonHandle1;
		private Panels.EnumerationsControl enumerations1;
	}
}