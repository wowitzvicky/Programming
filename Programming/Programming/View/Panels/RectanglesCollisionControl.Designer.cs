
namespace Programming.View.Panels
{
	partial class RectanglesCollisionControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
			this.RectanglesLabel = new System.Windows.Forms.Label();
			this.RectanglesIdLabel = new System.Windows.Forms.Label();
			this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
			this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
			this.RectangleYTextBox = new System.Windows.Forms.TextBox();
			this.RectangleXTextBox = new System.Windows.Forms.TextBox();
			this.RectangleHeightLabel = new System.Windows.Forms.Label();
			this.RectangleWidthLabel = new System.Windows.Forms.Label();
			this.RectangleYLabel = new System.Windows.Forms.Label();
			this.RectangleXLabel = new System.Windows.Forms.Label();
			this.SelectedRectangleLabel = new System.Windows.Forms.Label();
			this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
			this.RemoveRectangleButton = new System.Windows.Forms.Button();
			this.AddRectangleButton = new System.Windows.Forms.Button();
			this.RectangleCoordinatesListBox = new System.Windows.Forms.ListBox();
			this.CanvasPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// RectanglesLabel
			// 
			this.RectanglesLabel.Location = new System.Drawing.Point(28, 27);
			this.RectanglesLabel.Name = "RectanglesLabel";
			this.RectanglesLabel.Size = new System.Drawing.Size(267, 23);
			this.RectanglesLabel.TabIndex = 37;
			this.RectanglesLabel.Text = "Rectangles:";
			// 
			// RectanglesIdLabel
			// 
			this.RectanglesIdLabel.Location = new System.Drawing.Point(57, 284);
			this.RectanglesIdLabel.Name = "RectanglesIdLabel";
			this.RectanglesIdLabel.Size = new System.Drawing.Size(27, 23);
			this.RectanglesIdLabel.TabIndex = 36;
			this.RectanglesIdLabel.Text = "Id:";
			// 
			// RectangleHeightTextBox
			// 
			this.RectangleHeightTextBox.Location = new System.Drawing.Point(89, 399);
			this.RectangleHeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
			this.RectangleHeightTextBox.Size = new System.Drawing.Size(119, 22);
			this.RectangleHeightTextBox.TabIndex = 35;
			this.RectangleHeightTextBox.TextChanged += new System.EventHandler(this.RectangleHeightTextBox_TextChanged);
			// 
			// RectangleWidthTextBox
			// 
			this.RectangleWidthTextBox.Location = new System.Drawing.Point(89, 370);
			this.RectangleWidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
			this.RectangleWidthTextBox.Size = new System.Drawing.Size(119, 22);
			this.RectangleWidthTextBox.TabIndex = 34;
			this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
			// 
			// RectangleYTextBox
			// 
			this.RectangleYTextBox.Location = new System.Drawing.Point(89, 342);
			this.RectangleYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleYTextBox.Name = "RectangleYTextBox";
			this.RectangleYTextBox.Size = new System.Drawing.Size(119, 22);
			this.RectangleYTextBox.TabIndex = 33;
			this.RectangleYTextBox.TextChanged += new System.EventHandler(this.RectangleYTextBox_TextChanged);
			// 
			// RectangleXTextBox
			// 
			this.RectangleXTextBox.Location = new System.Drawing.Point(89, 315);
			this.RectangleXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleXTextBox.Name = "RectangleXTextBox";
			this.RectangleXTextBox.Size = new System.Drawing.Size(119, 22);
			this.RectangleXTextBox.TabIndex = 32;
			this.RectangleXTextBox.TextChanged += new System.EventHandler(this.RectangleXTextBox_TextChanged);
			// 
			// RectangleHeightLabel
			// 
			this.RectangleHeightLabel.Location = new System.Drawing.Point(28, 399);
			this.RectangleHeightLabel.Name = "RectangleHeightLabel";
			this.RectangleHeightLabel.Size = new System.Drawing.Size(56, 22);
			this.RectangleHeightLabel.TabIndex = 31;
			this.RectangleHeightLabel.Text = "Height:";
			// 
			// RectangleWidthLabel
			// 
			this.RectangleWidthLabel.Location = new System.Drawing.Point(28, 370);
			this.RectangleWidthLabel.Name = "RectangleWidthLabel";
			this.RectangleWidthLabel.Size = new System.Drawing.Size(56, 22);
			this.RectangleWidthLabel.TabIndex = 30;
			this.RectangleWidthLabel.Text = "Width:";
			// 
			// RectangleYLabel
			// 
			this.RectangleYLabel.Location = new System.Drawing.Point(57, 342);
			this.RectangleYLabel.Name = "RectangleYLabel";
			this.RectangleYLabel.Size = new System.Drawing.Size(27, 22);
			this.RectangleYLabel.TabIndex = 29;
			this.RectangleYLabel.Text = "Y:";
			// 
			// RectangleXLabel
			// 
			this.RectangleXLabel.Location = new System.Drawing.Point(57, 315);
			this.RectangleXLabel.Name = "RectangleXLabel";
			this.RectangleXLabel.Size = new System.Drawing.Size(27, 22);
			this.RectangleXLabel.TabIndex = 28;
			this.RectangleXLabel.Text = "X:";
			// 
			// SelectedRectangleLabel
			// 
			this.SelectedRectangleLabel.Location = new System.Drawing.Point(28, 262);
			this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
			this.SelectedRectangleLabel.Size = new System.Drawing.Size(144, 22);
			this.SelectedRectangleLabel.TabIndex = 27;
			this.SelectedRectangleLabel.Text = "Selected Rectangle:";
			// 
			// RectangleIdTextBox
			// 
			this.RectangleIdTextBox.Location = new System.Drawing.Point(89, 287);
			this.RectangleIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleIdTextBox.Name = "RectangleIdTextBox";
			this.RectangleIdTextBox.ReadOnly = true;
			this.RectangleIdTextBox.Size = new System.Drawing.Size(119, 22);
			this.RectangleIdTextBox.TabIndex = 26;
			// 
			// RemoveRectangleButton
			// 
			this.RemoveRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveRectangleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.RemoveRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("RemoveRectangleButton.Image")));
			this.RemoveRectangleButton.Location = new System.Drawing.Point(163, 224);
			this.RemoveRectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RemoveRectangleButton.Name = "RemoveRectangleButton";
			this.RemoveRectangleButton.Size = new System.Drawing.Size(67, 34);
			this.RemoveRectangleButton.TabIndex = 25;
			this.RemoveRectangleButton.UseVisualStyleBackColor = true;
			this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
			this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
			this.RemoveRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveRectangleButton_MouseMove);
			// 
			// AddRectangleButton
			// 
			this.AddRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddRectangleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.AddRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("AddRectangleButton.Image")));
			this.AddRectangleButton.Location = new System.Drawing.Point(89, 224);
			this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddRectangleButton.Name = "AddRectangleButton";
			this.AddRectangleButton.Size = new System.Drawing.Size(67, 34);
			this.AddRectangleButton.TabIndex = 24;
			this.AddRectangleButton.UseVisualStyleBackColor = true;
			this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
			this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
			this.AddRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddRectangleButton_MouseMove);
			// 
			// RectangleCoordinatesListBox
			// 
			this.RectangleCoordinatesListBox.FormattingEnabled = true;
			this.RectangleCoordinatesListBox.ItemHeight = 16;
			this.RectangleCoordinatesListBox.Location = new System.Drawing.Point(28, 54);
			this.RectangleCoordinatesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RectangleCoordinatesListBox.Name = "RectangleCoordinatesListBox";
			this.RectangleCoordinatesListBox.Size = new System.Drawing.Size(265, 164);
			this.RectangleCoordinatesListBox.TabIndex = 23;
			this.RectangleCoordinatesListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleCoordinatesListBox_SelectedIndexChanged);
			// 
			// CanvasPanel
			// 
			this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.CanvasPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CanvasPanel.Location = new System.Drawing.Point(300, 27);
			this.CanvasPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CanvasPanel.Name = "CanvasPanel";
			this.CanvasPanel.Size = new System.Drawing.Size(362, 414);
			this.CanvasPanel.TabIndex = 22;
			// 
			// RectanglesCollisionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.RectanglesLabel);
			this.Controls.Add(this.RectanglesIdLabel);
			this.Controls.Add(this.RectangleHeightTextBox);
			this.Controls.Add(this.RectangleWidthTextBox);
			this.Controls.Add(this.RectangleYTextBox);
			this.Controls.Add(this.RectangleXTextBox);
			this.Controls.Add(this.RectangleHeightLabel);
			this.Controls.Add(this.RectangleWidthLabel);
			this.Controls.Add(this.RectangleYLabel);
			this.Controls.Add(this.RectangleXLabel);
			this.Controls.Add(this.SelectedRectangleLabel);
			this.Controls.Add(this.RectangleIdTextBox);
			this.Controls.Add(this.RemoveRectangleButton);
			this.Controls.Add(this.AddRectangleButton);
			this.Controls.Add(this.RectangleCoordinatesListBox);
			this.Controls.Add(this.CanvasPanel);
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RectanglesCollisionControl";
			this.Size = new System.Drawing.Size(677, 454);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label RectanglesLabel;
		private System.Windows.Forms.Label RectanglesIdLabel;
		private System.Windows.Forms.TextBox RectangleHeightTextBox;
		private System.Windows.Forms.TextBox RectangleWidthTextBox;
		private System.Windows.Forms.TextBox RectangleYTextBox;
		private System.Windows.Forms.TextBox RectangleXTextBox;
		private System.Windows.Forms.Label RectangleHeightLabel;
		private System.Windows.Forms.Label RectangleWidthLabel;
		private System.Windows.Forms.Label RectangleYLabel;
		private System.Windows.Forms.Label RectangleXLabel;
		private System.Windows.Forms.Label SelectedRectangleLabel;
		private System.Windows.Forms.TextBox RectangleIdTextBox;
		private System.Windows.Forms.Button RemoveRectangleButton;
		private System.Windows.Forms.Button AddRectangleButton;
		private System.Windows.Forms.ListBox RectangleCoordinatesListBox;
		private System.Windows.Forms.Panel CanvasPanel;
	}
}
