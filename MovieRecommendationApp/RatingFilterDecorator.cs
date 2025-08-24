using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendationApp
{
    using System.Collections.Generic;
    using System.Linq;

    public class RatingFilterDecorator : MovieRecommendationDecorator
    {
        private double rating;

        public RatingFilterDecorator(IMovieRecommendation recommendation, double rating)
            : base(recommendation)
        {
            this.rating = rating;
        }

        public override List<Movie> GetMovies()
        {
            return recommendation.GetMovies()
                .Where(m => m.Rating == rating)
                .ToList();
        }
    }
}
