using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Показывает данные из перечислений.
    /// </summary>
	public partial class EnumerationsControl : UserControl
	{
		public EnumerationsControl()
		{
			InitializeComponent();
			EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
			EnumsListBox.SelectedIndex = 0;
		}

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Enum)EnumsListBox.SelectedItem;
            switch (item)
            {
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Color));
                    break;
                case Enums.FormOfEducation:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.FormOfEducation));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Genre));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Season));
                    break;
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Weekday));
                    break;
                case Enums.SmartphoneManufacturers:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.SmartphoneManufacturers));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedValue).ToString();
        }
    }
}
