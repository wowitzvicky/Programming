using System;
using System.Windows.Forms;
using Movie = Programming.Model.Classes.Movie;
using AppColor = Programming.Model.Classes.AppColor;

namespace Programming.View.Panels
{
    /// <summary>
    /// Показывает информацию о фильме и находит фильм с наивысшим рейтингом.
    /// </summary>
	public partial class MoviesControl : UserControl
	{
        /// <summary>
        /// Хранит данные о текущем фильме.
        /// </summary>
		private Movie _currentMovie = new Movie();

        /// <summary>
        /// Создаёт случайные значения.
        /// </summary>
        private Random _random = new Random();
        
		public MoviesControl()
		{
			InitializeComponent();

            Movie[] movies = new Movie[5];

            for (int i = 0; i < 5; i++)
            {
                movies[i] = new Movie(
                    "The Great Gatsby",
                    _random.Next(1, 250),
                    _random.Next(1900, 2022),
                    "Novel",
                    _random.Next(0, 10),
                    i + 1);
                MoviesListBox.Items.Add(movies[i]);
            }
        }

        /// <summary>
        /// Обновляет информацию о фильме.
        /// </summary>
        private void PrintMoviesTextBox()
        {
            if (MoviesListBox.SelectedItem is Movie temp)
            {
                _currentMovie = temp;
                TitleTextBox.Text = "" + _currentMovie.Name;
                DurationTextBox.Text = "" + _currentMovie.Duration;
                YearTextBox.Text = "" + _currentMovie.Year;
                GenreTextBox.Text = "" + _currentMovie.Genre;
                RatingTextBox.Text = "" + _currentMovie.Rating;
            }
        }

        /// <summary>
        /// Находит фильм с наивысшим рейтингом.
        /// </summary>
        /// <returns>Возвращает индекс фильма с наивысшим рейтингом.</returns>
        private int FindMovieWithMaxRating()
        {
            double max = 0;
            int currentRating = 0;
            for (int i = 0; i < 5; i++)
            {
                MoviesListBox.SelectedIndex = i;
                if (MoviesListBox.SelectedItem is Movie temp)
                {
                    if (temp.Rating > max)
                    {
                        max = temp.Rating;
                        currentRating = i;
                    }
                }
            }
            return currentRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintMoviesTextBox();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = TitleTextBox.Text;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = AppColor.CorrectBackColor;
            }
            catch
            {
                DurationTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Year = int.Parse(YearTextBox.Text);
                YearTextBox.BackColor = AppColor.CorrectBackColor;
            }
            catch
            {
                YearTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColor.CorrectBackColor;
            }
            catch
            {
                RatingTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating();
        }
    }
}
