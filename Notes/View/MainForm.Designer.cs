
namespace Notes
{
	partial class MainForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notesControl1 = new Notes.View.Panels.NotesControl();
			this.SuspendLayout();
			// 
			// notesControl1
			// 
			this.notesControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.notesControl1.AutoSize = true;
			this.notesControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.notesControl1.Location = new System.Drawing.Point(16, 4);
			this.notesControl1.Margin = new System.Windows.Forms.Padding(5);
			this.notesControl1.MinimumSize = new System.Drawing.Size(804, 628);
			this.notesControl1.Name = "notesControl1";
			this.notesControl1.Size = new System.Drawing.Size(804, 628);
			this.notesControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 641);
			this.Controls.Add(this.notesControl1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(835, 678);
			this.Name = "MainForm";
			this.Text = "Заметки";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private Notes.View.Panels.NotesControl notesControl1;
	}
}

