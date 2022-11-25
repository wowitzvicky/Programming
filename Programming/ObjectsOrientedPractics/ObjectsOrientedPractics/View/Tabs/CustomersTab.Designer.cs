using System.ComponentModel;
using ObjectsOrientedPractics.View.Controls;

namespace ObjectsOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectsOrientedPractics.Model.Address address = new ObjectsOrientedPractics.Model.Address();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressControl = new AddressControl();
            this.SuspendLayout();
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(88, 19);
            this.CustomersLabel.TabIndex = 2;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 22);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(282, 452);
            this.CustomersListBox.TabIndex = 3;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(0, 480);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(90, 39);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(96, 480);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(90, 39);
            this.RemoveCustomerButton.TabIndex = 5;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(288, 3);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(164, 16);
            this.SelectedCustomerLabel.TabIndex = 8;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.Location = new System.Drawing.Point(288, 36);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(35, 22);
            this.CustomerIdLabel.TabIndex = 9;
            this.CustomerIdLabel.Text = "ID:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Location = new System.Drawing.Point(288, 64);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(90, 22);
            this.CustomerNameLabel.TabIndex = 10;
            this.CustomerNameLabel.Text = "Full Name:";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(384, 36);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(108, 22);
            this.CustomerIdTextBox.TabIndex = 11;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(384, 64);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(108, 22);
            this.CustomerNameTextBox.TabIndex = 12;
            this.CustomerNameTextBox.Leave += new System.EventHandler(this.CustomerNameTextBox_Leave);
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // AddressControl
            // 
            address.Apartment = null;
            address.Building = null;
            address.City = null;
            address.Country = null;
            address.Index = 0;
            address.Street = null;
            this.AddressControl.Address = address;
            this.AddressControl.Location = new System.Drawing.Point(292, 110);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(614, 364);
            this.AddressControl.TabIndex = 13;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerIdTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(947, 551);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private AddressControl AddressControl;

        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;

        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerIdLabel;

        private System.Windows.Forms.Label CostLabel;

        private System.Windows.Forms.Label IdLabel;

        private System.Windows.Forms.Label SelectedCustomerLabel;

        private System.Windows.Forms.Button RemoveCustomerButton;

        private System.Windows.Forms.Button AddCustomerButton;

        private System.Windows.Forms.ListBox CustomersListBox;

        private System.Windows.Forms.Label CustomersLabel;

        #endregion
    }
}