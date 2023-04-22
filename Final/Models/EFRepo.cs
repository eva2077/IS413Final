using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//namespace Final.Models
//{
//    public class EFRepo : IRepo
//    {
//        //Context is refering to the file under models
//        private Context _context { get; set; }
//        public EFRepo(Context temp)
//        {
//            _context = temp;
//        }
//        public IQueryable<Movie> Movies => _context.Movies;
//    }
//}
using Final.Models;

public class EFRepo : IRepo
{
    private Context _context { get; set; }

    public EFRepo(Context context)
    {
        _context = context;
    }

    public IQueryable<Movie> Movies
    {
        get { return _context.Movies; }
        set { _context.Movies = (DbSet<Movie>)value; }
    }
    public void AddMovie(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
    }
}

