﻿using System.ComponentModel;

namespace ObjectsOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(6, 6);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(148, 22);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.Location = new System.Drawing.Point(0, 38);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(85, 23);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.Location = new System.Drawing.Point(0, 66);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(85, 23);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(359, 66);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(85, 23);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.Location = new System.Drawing.Point(0, 98);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(85, 23);
            this.StreetLabel.TabIndex = 4;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.Location = new System.Drawing.Point(0, 123);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(85, 23);
            this.BuildingLabel.TabIndex = 5;
            this.BuildingLabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.Location = new System.Drawing.Point(251, 123);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(85, 23);
            this.ApartmentLabel.TabIndex = 6;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(91, 39);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(112, 22);
            this.PostIndexTextBox.TabIndex = 7;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(91, 67);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(245, 22);
            this.CountryTextBox.TabIndex = 8;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(393, 67);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(201, 22);
            this.CityTextBox.TabIndex = 9;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(91, 95);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(503, 22);
            this.StreetTextBox.TabIndex = 10;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(91, 123);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(112, 22);
            this.BuildingTextBox.TabIndex = 11;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(332, 124);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(112, 22);
            this.ApartmentTextBox.TabIndex = 12;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PostIndexTextBox);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PostIndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(670, 166);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox ApartmentTextBox;

        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;

        private System.Windows.Forms.TextBox CityTextBox;

        private System.Windows.Forms.TextBox CountryTextBox;

        private System.Windows.Forms.TextBox PostIndexTextBox;

        private System.Windows.Forms.Label ApartmentLabel;

        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;

        private System.Windows.Forms.Label CityLabel;

        private System.Windows.Forms.Label CountryLabel;

        private System.Windows.Forms.Label PostIndexLabel;

        private System.Windows.Forms.Label DeliveryAddressLabel;

        #endregion
    }
}