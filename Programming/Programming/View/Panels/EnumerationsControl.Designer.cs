
namespace Programming.View.Panels
{
	partial class EnumerationsControl
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
			this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
			this.IntValueTextBox = new System.Windows.Forms.TextBox();
			this.IntValueLabel = new System.Windows.Forms.Label();
			this.ChooseValueLabel = new System.Windows.Forms.Label();
			this.ChooseEnumLabel = new System.Windows.Forms.Label();
			this.ValuesListBox = new System.Windows.Forms.ListBox();
			this.EnumsListBox = new System.Windows.Forms.ListBox();
			this.EnumerationsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// EnumerationsGroupBox
			// 
			this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
			this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
			this.EnumerationsGroupBox.Controls.Add(this.ChooseValueLabel);
			this.EnumerationsGroupBox.Controls.Add(this.ChooseEnumLabel);
			this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
			this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
			this.EnumerationsGroupBox.Location = new System.Drawing.Point(2, 2);
			this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
			this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.EnumerationsGroupBox.Size = new System.Drawing.Size(320, 207);
			this.EnumerationsGroupBox.TabIndex = 8;
			this.EnumerationsGroupBox.TabStop = false;
			this.EnumerationsGroupBox.Text = "Enumerations";
			// 
			// IntValueTextBox
			// 
			this.IntValueTextBox.Location = new System.Drawing.Point(258, 30);
			this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.IntValueTextBox.Name = "IntValueTextBox";
			this.IntValueTextBox.Size = new System.Drawing.Size(59, 20);
			this.IntValueTextBox.TabIndex = 6;
			// 
			// IntValueLabel
			// 
			this.IntValueLabel.Location = new System.Drawing.Point(258, 15);
			this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.IntValueLabel.Name = "IntValueLabel";
			this.IntValueLabel.Size = new System.Drawing.Size(58, 13);
			this.IntValueLabel.TabIndex = 5;
			this.IntValueLabel.Text = "Int Value:";
			// 
			// ChooseValueLabel
			// 
			this.ChooseValueLabel.Location = new System.Drawing.Point(130, 15);
			this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ChooseValueLabel.Name = "ChooseValueLabel";
			this.ChooseValueLabel.Size = new System.Drawing.Size(122, 13);
			this.ChooseValueLabel.TabIndex = 4;
			this.ChooseValueLabel.Text = "Choose value:";
			// 
			// ChooseEnumLabel
			// 
			this.ChooseEnumLabel.Location = new System.Drawing.Point(4, 15);
			this.ChooseEnumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ChooseEnumLabel.Name = "ChooseEnumLabel";
			this.ChooseEnumLabel.Size = new System.Drawing.Size(122, 13);
			this.ChooseEnumLabel.TabIndex = 3;
			this.ChooseEnumLabel.Text = "Choose enumeration:";
			// 
			// ValuesListBox
			// 
			this.ValuesListBox.FormattingEnabled = true;
			this.ValuesListBox.Location = new System.Drawing.Point(131, 30);
			this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
			this.ValuesListBox.Name = "ValuesListBox";
			this.ValuesListBox.Size = new System.Drawing.Size(123, 173);
			this.ValuesListBox.TabIndex = 1;
			this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
			// 
			// EnumsListBox
			// 
			this.EnumsListBox.FormattingEnabled = true;
			this.EnumsListBox.Location = new System.Drawing.Point(4, 30);
			this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.EnumsListBox.Name = "EnumsListBox";
			this.EnumsListBox.Size = new System.Drawing.Size(123, 173);
			this.EnumsListBox.TabIndex = 0;
			this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
			// 
			// Enumerations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.EnumerationsGroupBox);
			this.Name = "EnumerationsControl";
			this.Size = new System.Drawing.Size(324, 209);
			this.EnumerationsGroupBox.ResumeLayout(false);
			this.EnumerationsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox EnumerationsGroupBox;
		private System.Windows.Forms.TextBox IntValueTextBox;
		private System.Windows.Forms.Label IntValueLabel;
		private System.Windows.Forms.Label ChooseValueLabel;
		private System.Windows.Forms.Label ChooseEnumLabel;
		private System.Windows.Forms.ListBox ValuesListBox;
		private System.Windows.Forms.ListBox EnumsListBox;
	}
}
