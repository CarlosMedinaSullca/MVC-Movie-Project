using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService< DbContextOptions<MvcMovieContext>>()))
        {
            //Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The lord of the rings",
                    ReleaseDate = DateTime.Parse("2001-12-10"),
                    Genre = "Fantasy",
                    Rating = "G",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "A beautiful mind",
                    ReleaseDate = DateTime.Parse("2002-03-01"),
                    Genre = "Biografic drama",
                    Rating = "GP",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Mouse hunt",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Comedy",
                    Rating = "G",
                    Price = 7.99M
                }
            );
            context.SaveChanges();
        }
    }
}