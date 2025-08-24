using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MovieRecommendationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetRecommendations_Click(object sender, EventArgs e)
        {
            IMovieRecommendation recommendation = new BasicRecommendation();

            if (!string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                recommendation = new GenreFilterDecorator(recommendation, txtGenre.Text);
            }

            if (double.TryParse(txtRating.Text, out double rating))
            {
                recommendation = new RatingFilterDecorator(recommendation, rating);
            }

            if (int.TryParse(txtYear.Text, out int year))
            {
                recommendation = new YearFilterDecorator(recommendation, year);
            }

            var movies = recommendation.GetMovies();

            listBoxMovies.Items.Clear();
            if (movies.Count == 0)
            {
                listBoxMovies.Items.Add("There are no movies matching the filter.");
            }
            else
            {
                foreach (var movie in movies)
                {
                    listBoxMovies.Items.Add($"{movie.Title} ({movie.Year}) - {movie.Genre} - {movie.Rating}");
                }
            }
        }
    }
}