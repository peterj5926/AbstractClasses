using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Library;
using CsvHelper;
using Helper;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace AbstractClasses.MediaSelection
{
    public class MediaSelection
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }


       
        public void Search()
        {
            int choice;
            bool isComplete = false;
            Console.WriteLine("Welcome to the Media Libary!");
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Available Media for Display");
                Console.WriteLine("1. Movies");
                Console.WriteLine("2. Shows");
                Console.WriteLine("3. Videos");
                Console.WriteLine("4. Exit");
                choice = Input.GetIntWithPrompt("Please select a number to view: ", "That is not a number, Please try again");
                if (choice >4 || choice < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("I'm sorry, that is not a Menu option!");
                }
                else if (choice == 1)
                {
                    string file = ("movies.csv");                                                 // The hardest part of this assignment was originally I used CsvHelper when we first started working with the movies.csv         
                    StreamReader sr = new StreamReader(file);                                     // so it was difficult to slice things up. I'm sure Csvhelper could of done alot of it for me but its a lot
                    sr.ReadLine();                                                                // of extra time learning how to adapt a nuget that I've never used before to a concept I've never done before. 
                    Movies = new List<Movie>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] movieDetails = line.Split(',');
                        Movies.Add(new Movie() { Id = (int)UInt64.Parse(movieDetails[0]),
                            Title = movieDetails[1],
                            Genres = (string[])movieDetails[2].Split('|') });

                    }
                    sr.Close();
                    foreach (Movie movie in Movies)
                    {
                        movie.Display();
                    }
                    Movies.Clear();                                                               // Because we talked about loading a whole bunch of stuff into memory loaded things individually and 
                                                                                                  // then wipe things out after it was displayed, might not really make a difference but just thought why not 

                }
                else if (choice == 2)
                {
                    string file = ("shows.csv");
                    StreamReader sr = new StreamReader(file);
                    sr.ReadLine();
                    Shows = new List<Show>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] showDetails = line.Split(',');
                        Shows.Add(new Show() { Id = (int)UInt64.Parse(showDetails[0]),
                            Title = showDetails[1],
                            Season = (int)UInt64.Parse(showDetails[2]),
                            Episode = (int)UInt64.Parse(showDetails[3]),
                            Writers = (string[])showDetails[4].Split('|') });
                    }
                    sr.Close();
                    foreach (Show sho in Shows)
                    {
                        sho.Display();
                    }
                    Shows.Clear();


                }
                else if (choice == 3)
                {
                    string file = ("videos.csv");
                    StreamReader sr = new StreamReader(file);
                    sr.ReadLine();
                    Videos = new List<Video>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] videoDetails = line.Split(',');
                        Videos.Add(new Video() { Id = (int)UInt64.Parse(videoDetails[0]),
                            Title = videoDetails[1],
                            Format = videoDetails[2],
                            Length = (int)UInt64.Parse(videoDetails[3]),
                            Regions = (int[])Array.ConvertAll(videoDetails[4].Split('|'), s => int.Parse(s)) });

                    }
                    sr.Close();
                    foreach (Video v in Videos)
                    {
                        v.Display();
                    }
                    Videos.Clear();


                }
                else if (choice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Media Libary, Good Bye!");
                    isComplete = true;
                }
            }while(!isComplete);
          

        }
       
    }

}

