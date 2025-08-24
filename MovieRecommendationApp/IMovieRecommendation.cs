using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendationApp
{
    using System.Collections.Generic;

    public interface IMovieRecommendation
    {
        List<Movie> GetMovies();
    }
}
