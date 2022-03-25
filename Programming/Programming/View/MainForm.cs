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
        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();
        private Model.Classes.Film _currentFilm = new Model.Classes.Film();
        public MainForm()
        {
            InitializeComponent();

            Model.Classes.Rectangle[] _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 50), random.Next(1, 50), "White", i + 1);
                RectanglesListBox.Items.Add(_rectangles[i]);
            }

            Model.Classes.Film[] _films = new Model.Classes.Film[5];
            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Model.Classes.Film("The Great Gatsby", random.Next(1, 250), random.Next(1900, 2022), "Novel", random.Next(0, 10), i + 1);
                FilmsListBox.Items.Add(_films[i]);
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
            PrintTextBox();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = Color.LightPink;
                return;
            }
        }


        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = Color.LightPink;
                return;
            }
        }
        
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth()
        {
            double _max = 0;
            int _currentIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                RectanglesListBox.SelectedIndex = i;
                if (RectanglesListBox.SelectedItem is Model.Classes.Rectangle temp)
                {
                    if (temp.Width > _max)
                    {
                        _max = temp.Width;
                        _currentIndex = i;
                    }
                }
            }

            return _currentIndex + 1;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void PrintTextBox()
        {
            if (RectanglesListBox.SelectedItem is Model.Classes.Rectangle temp)
            {
                _currentRectangle = temp;
                LengthTextBox.Text = "" + _currentRectangle.Length;
                WidthTextBox.Text = "" + _currentRectangle.Width;
                ColorTextBox.Text = "" + _currentRectangle.Color;
            }
        }

        private void PrintFilmsTextBox()
        {
            if (FilmsListBox.SelectedItem is Model.Classes.Film temp)
            {
                _currentFilm = temp;
                TitleTextBox.Text = "" + _currentFilm.Name;
                DurationTextBox.Text = "" + _currentFilm.Duration;
                YearTextBox.Text = "" + _currentFilm.Year;
                GenreTextBox.Text = "" + _currentFilm.Genre;
                RatingTextBox.Text = "" + _currentFilm.Rating;
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintFilmsTextBox();
        }
        
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = TitleTextBox.Text;
        }
        
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = Color.White;
            }
            catch
            {
                DurationTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Year = int.Parse(YearTextBox.Text);
                YearTextBox.BackColor = Color.White;
            }
            catch
            {
                YearTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = Double.Parse(DurationTextBox.Text);
                RatingTextBox.BackColor = Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = Color.LightPink;
                return;
            }
        }
        private int FindFilmWithMaxRating()
        {
            double _max = 0;
            int _currentRating = 0;
            for (int i = 0; i < 5; i++)
            {
                FilmsListBox.SelectedIndex = i;
                if (FilmsListBox.SelectedItem is Model.Classes.Film temp)
                {
                    if (temp.Rating > _max)
                    {
                        _max = temp.Rating;
                        _currentRating = i;
                    }
                }
            }

            return _currentRating + 1;
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
        }
    }
}