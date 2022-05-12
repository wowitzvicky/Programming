
namespace Programming.View.Panels
{
	partial class SeasonHandleControl
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
			this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
			this.GoButton = new System.Windows.Forms.Button();
			this.ChooseLabel = new System.Windows.Forms.Label();
			this.SeasonComboBox = new System.Windows.Forms.ComboBox();
			this.SeasonHandleGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SeasonHandleGroupBox
			// 
			this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
			this.SeasonHandleGroupBox.Controls.Add(this.ChooseLabel);
			this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
			this.SeasonHandleGroupBox.Location = new System.Drawing.Point(2, 2);
			this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
			this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.SeasonHandleGroupBox.Size = new System.Drawing.Size(148, 117);
			this.SeasonHandleGroupBox.TabIndex = 15;
			this.SeasonHandleGroupBox.TabStop = false;
			this.SeasonHandleGroupBox.Text = "Season Handle";
			// 
			// GoButton
			// 
			this.GoButton.Location = new System.Drawing.Point(88, 35);
			this.GoButton.Margin = new System.Windows.Forms.Padding(2);
			this.GoButton.Name = "GoButton";
			this.GoButton.Size = new System.Drawing.Size(56, 20);
			this.GoButton.TabIndex = 13;
			this.GoButton.Text = "Go!";
			this.GoButton.UseVisualStyleBackColor = true;
			this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
			// 
			// ChooseLabel
			// 
			this.ChooseLabel.Location = new System.Drawing.Point(4, 15);
			this.ChooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ChooseLabel.Name = "ChooseLabel";
			this.ChooseLabel.Size = new System.Drawing.Size(88, 18);
			this.ChooseLabel.TabIndex = 12;
			this.ChooseLabel.Text = "Choose season:";
			// 
			// SeasonComboBox
			// 
			this.SeasonComboBox.FormattingEnabled = true;
			this.SeasonComboBox.Location = new System.Drawing.Point(4, 35);
			this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SeasonComboBox.Name = "SeasonComboBox";
			this.SeasonComboBox.Size = new System.Drawing.Size(80, 21);
			this.SeasonComboBox.TabIndex = 11;
			// 
			// SeasonHandle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SeasonHandleGroupBox);
			this.Name = "SeasonHandleControl";
			this.Size = new System.Drawing.Size(153, 122);
			this.SeasonHandleGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
		private System.Windows.Forms.Button GoButton;
		private System.Windows.Forms.Label ChooseLabel;
		private System.Windows.Forms.ComboBox SeasonComboBox;
	}
}
