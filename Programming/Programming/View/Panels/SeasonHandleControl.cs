using System;
using System.Windows.Forms;
using Programming.Model;
using AppColor = Programming.Model.Classes.AppColor;

namespace Programming.View.Panels
{
	public partial class SeasonHandleControl : UserControl
	{
		public SeasonHandleControl()
		{
			InitializeComponent();
            SeasonComboBox.Items.Add(Season.Winter);
            SeasonComboBox.Items.Add(Season.Spring);
            SeasonComboBox.Items.Add(Season.Summer);
            SeasonComboBox.Items.Add(Season.Fall);
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                return;
            }

            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Fall:
                    BackColor = AppColor.Chocolate;
                    break;
                case Season.Winter:
                    MessageBox.Show("Оледенеть можно!");
                    break;
                case Season.Spring:
                    BackColor = AppColor.Chartreuse;
                    break;
            }
        }
    }
}
