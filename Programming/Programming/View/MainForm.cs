using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Color = System.Drawing.Color;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle _rectangle = new Model.Classes.Rectangle();
        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();
        public MainForm()
        {
            InitializeComponent();

            var _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 50), random.Next(1, 50), "White");
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

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
            if (Enum.TryParse(ParseTextBox.Text, out value))
            {
                ParseInfoLabel.Text = $"\"Это день недели ({ParseTextBox.Text} = {(int)value})\"";
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}