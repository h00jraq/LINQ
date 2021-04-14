using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var movies = new List<Movie>
            { 
                new Movie { Title = "Godzilla", Rating = 8.5f, Year = 2015 },
                new Movie { Title = "King-Kong", Rating = 9.0f, Year = 2012 },
                new Movie { Title = "LOTR", Rating = 10.0f, Year = 2005 },
                new Movie { Title = "Batman", Rating = 7.25f, Year = 2010 },
                new Movie { Title = "Spiderman", Rating = 7.25f, Year = 1988 },
                new Movie { Title = "Star Wars VI", Rating = 7.25f, Year = 1995 }
            };
            Console.WriteLine("objects created");
            var query = movies.Where(m => m.Year > 2000);

            //Console.WriteLine(query.Count());
            var enumarator = query.GetEnumerator();
            while (enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current.Title);
            }

            //foreach (var movie in query)
            //{
            //    Console.WriteLine(movie.Title);
            //}
            //Console.WriteLine("---Extensiion Linq method---");

            //var query3 = movies.Filter(m => m.Year > 2000);
                             

            //foreach (var movie in query3)
            //{
            //    Console.WriteLine(movie.Title);
            //}
            //Console.WriteLine("--My Own Extension method---");

            //var query2 = from movie in movies
            //             where movie.Year > 2000
            //             select movie;

            //foreach (var movie in query2)
            //{
            //    Console.WriteLine(movie.Title);
            //}
            //Console.WriteLine("--Linq query---");
        }
    }
}
