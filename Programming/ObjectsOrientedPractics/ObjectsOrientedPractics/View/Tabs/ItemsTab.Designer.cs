using System.ComponentModel;

namespace ObjectsOrientedPractics.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(282, 452);
            this.ItemsListBox.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(71, 16);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 477);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(99, 477);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 39);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(342, 30);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(108, 22);
            this.IdTextBox.TabIndex = 4;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(342, 58);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(108, 22);
            this.CostTextBox.TabIndex = 5;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(291, 30);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(35, 22);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(291, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(121, 16);
            this.SelectedItemLabel.TabIndex = 7;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // CostLabel
            // 
            this.CostLabel.Location = new System.Drawing.Point(291, 58);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(45, 22);
            this.CostLabel.TabIndex = 8;
            this.CostLabel.Text = "Cost:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Location = new System.Drawing.Point(291, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 22);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(291, 117);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(420, 89);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(291, 232);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(420, 130);
            this.DescriptionTextBox.TabIndex = 11;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(291, 209);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(764, 533);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label DescriptionLabel;

        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.TextBox DescriptionTextBox;

        private System.Windows.Forms.Label NameLabel;

        private System.Windows.Forms.Label IdLabel;

        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;

        private System.Windows.Forms.Label ItemsLabel;

        private System.Windows.Forms.ListBox ItemsListBox;

        #endregion
    }
}