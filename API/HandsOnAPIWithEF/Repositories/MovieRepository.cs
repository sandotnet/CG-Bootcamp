using HandsOnAPIWithEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HandsOnAPIWithEF.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDBContext db;
        public MovieRepository()
        {
            db = new MovieDBContext();
        }
        public void Add(Movie movie)
        {
           db.Movies.Add(movie);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
           Movie movie=db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public Movie Get(int id)
        {
            return db.Movies.Find(id);
        }

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public void Update(Movie movie)
        {
            db.Movies.Update(movie);
            db.SaveChanges();
        }
    }
}
