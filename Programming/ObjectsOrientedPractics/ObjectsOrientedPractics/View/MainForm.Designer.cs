namespace ObjectsOrientedPractics
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectsOrientedPractics.Tabs.ItemsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectsOrientedPractics.Tabs.CustomersTab();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CustomersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ItemsTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "itemsTab1";
            this.ItemsTab.Size = new System.Drawing.Size(813, 591);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Name = "tabPage2";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(819, 597);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.BackColor = System.Drawing.SystemColors.Control;
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "customersTab1";
            this.CustomersTab.Size = new System.Drawing.Size(813, 591);
            this.CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private ObjectsOrientedPractics.Tabs.CustomersTab CustomersTab;

        private ObjectsOrientedPractics.Tabs.ItemsTab ItemsTab;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CustomersTabPage;

        #endregion
    }
}