using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendationApp
{
    using System.Collections.Generic;
    using System.Linq;

    public class GenreFilterDecorator : MovieRecommendationDecorator
    {
        private string genre;

        public GenreFilterDecorator(IMovieRecommendation recommendation, string genre)
            : base(recommendation)
        {
            this.genre = genre;
        }

        public override List<Movie> GetMovies()
        {
            return recommendation.GetMovies()
                .Where(m => m.Genre.Equals(genre, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
