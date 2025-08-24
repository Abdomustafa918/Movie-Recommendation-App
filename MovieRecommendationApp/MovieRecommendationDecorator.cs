using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendationApp
{
    using System.Collections.Generic;

    public abstract class MovieRecommendationDecorator : IMovieRecommendation
    {
        protected IMovieRecommendation recommendation;

        public MovieRecommendationDecorator(IMovieRecommendation recommendation)
        {
            this.recommendation = recommendation;
        }

        public abstract List<Movie> GetMovies();
    }
}
