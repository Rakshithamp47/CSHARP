using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace Sept13Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.AddMovieDetails("Vikrant Rona", "Kannada", "Suspense Thriller", 90);
            Movie m2 = new Movie();
            m2.AddMovieDetails("Phantom", "Hindi", "Action", 20);
            Movie m3 = new Movie();
            m3.AddMovieDetails("Money Heist", "English", "Mystery", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("Mersal", "Tamil", "Action", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("99", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("Don't Brethe", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("Deadpool", "English", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("I", "Tamil", "Sci-fi", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("MCA", "Telugu", "Sci-fi", 120);
            Movie m10 = new Movie();
            m10.AddMovieDetails("West World", "English", "Sci-fi", 120);
            
            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();
            User u7 = new User();
            User u8 = new User();
            User u9 = new User();
            User u10 = new User();

            u2.AddUser("Rakshitha", "Navya", "Silver");
            u3.AddUser("Rakshitha", "Navya", "Silver");
            u4.AddUser("Rakshitha", "Navya" ,"Silver");
            u5.AddUser("Rakshitha", "Navya", "Silver");
            u6.AddUser("Rakshitha", "Navya", "Silver");
            u7.AddUser("Rakshitha", "Navya", "Silver");
            u8.AddUser("Rakshitha", "Navya", "Silver");
            u9.AddUser("Rakshitha", "Navya", "Silver");
            u10.AddUser("Rakshitha", "Navya", "Silver");
            u1.BorrowMovie(m1);
            u2.BorrowMovie(m1);
            u4.BorrowMovie(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u2.RetrunMovie(m1, 4);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u3.BorrowMovie(m1);
            u6.BorrowMovie(m1);
            u5.BorrowMovie(m1);
            u7.BorrowMovie(m1);
            u8.BorrowMovie(m1);
            u9.BorrowMovie(m1);
            u10.BorrowMovie(m1);

            u1.RetrunMovie(m2, 5);
            u1.BorrowMovie(m3);
            u1.ShowMyList();
            Console.WriteLine("==================================================");
            u1.SearchByLanguage("Kannada");
            Console.WriteLine("==================================================");
            u1.SearchByGenre("Suspense Thriller");

        }
    }
}