using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming1.Model;
using Color = System.Drawing.Color;

namespace Programming1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.Items.Add(Season.Winter);
            SeasonComboBox.Items.Add(Season.Spring);
            SeasonComboBox.Items.Add(Season.Summer);
            SeasonComboBox.Items.Add(Season.Fall);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Enum) EnumsListBox.SelectedItem;
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
            IntValueTextBox.Text = ((int) ValuesListBox.SelectedValue).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday value;
            if (Enum.TryParse(parseTextBox.Text, out value))
            {
                ParseInfoLabel.Text = $"\"Это день недели ({parseTextBox.Text} = {(int)value})\"";
            }
            else
            {
                ParseInfoLabel.Text = "\"Нет такого дня недели\"";
            }
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
                    BackColor = Color.Chocolate;
                    break;
                case Season.Winter:
                    MessageBox.Show("Оледенеть можно!");
                    break;
                case Season.Spring:
                    BackColor = Color.Chartreuse;
                    break;
            }
        }
    }
}