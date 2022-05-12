using System;
using System.Windows.Forms;
using Programming.Model;
namespace Programming.View.Panels
{
    /// <summary>
    /// Проверяет существует ли написанный день недели.
    /// </summary>
	public partial class WeekdayParsingControl : UserControl
	{
		public WeekdayParsingControl()
		{
			InitializeComponent();
		}

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday value;
            if (Enum.TryParse(ParseTextBox.Text, out value))
            {
                ParseInfoLabel.Text = $"\"Это день недели ({ParseTextBox.Text} = {(int)value+1})\"";
            }
            else
            {
                ParseInfoLabel.Text = "\"Нет такого дня недели\"";
            }
        }
    }
}
