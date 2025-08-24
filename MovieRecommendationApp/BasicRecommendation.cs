using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MovieRecommendationApp
{
    public class BasicRecommendation : IMovieRecommendation
    {
        private List<Movie> movies;

        public BasicRecommendation()
        {
            LoadMoviesFromJson();
        }

        private void LoadMoviesFromJson()
        {
            string filePath = "movies.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                movies = JsonSerializer.Deserialize<List<Movie>>(json);
            }
            else
            {
                movies = new List<Movie>();
            }
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
    }
}
