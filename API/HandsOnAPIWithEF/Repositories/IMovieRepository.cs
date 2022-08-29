using HandsOnAPIWithEF.Entities;
using System.Collections.Generic;
namespace HandsOnAPIWithEF.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie Get(int id);
        void Update(Movie movie);
        void Delete(int id);
        void Add(Movie movie);
    }
}
