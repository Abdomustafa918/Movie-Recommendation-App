using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendationApp
{
    using System.Collections.Generic;
    using System.Linq;

    public class YearFilterDecorator : MovieRecommendationDecorator
    {
        private int year;

        public YearFilterDecorator(IMovieRecommendation recommendation, int year)
            : base(recommendation)
        {
            this.year = year;
        }

        public override List<Movie> GetMovies()
        {
            return recommendation.GetMovies()
                .Where(m => m.Year == year)
                .ToList();
        }
    }
}
