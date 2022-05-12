using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetTop30GrossingMovies()
        {
            // Dapper
            // var top30Movies = movies.GetMovies().OrderByDescending(m => m.Revenue).Take(30);
            throw new NotImplementedException();
        }
    }
}
