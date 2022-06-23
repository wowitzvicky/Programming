
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notesControl1 = new Notes.View.Panels.NotesControl();
			this.SuspendLayout();
			// 
			// notesControl1
			// 
			this.notesControl1.AutoSize = true;
			this.notesControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.notesControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.notesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesControl1.Location = new System.Drawing.Point(0, 0);
			this.notesControl1.MinimumSize = new System.Drawing.Size(603, 510);
			this.notesControl1.Name = "notesControl1";
			this.notesControl1.Size = new System.Drawing.Size(615, 521);
			this.notesControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 521);
			this.Controls.Add(this.notesControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(631, 560);
			this.Name = "MainForm";
			this.Text = "Заметки";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private View.Panels.NotesControl notesControl1;
	}
}

