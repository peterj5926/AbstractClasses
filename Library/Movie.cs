using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Library
{
    public class Movie : MediaLibary
    {
        public string[] Genres { get; set; }

        public override void Display()
        {
            
            Console.WriteLine();
            System.Console.WriteLine($"Movie ID: {Id}");
            System.Console.WriteLine($"Title:    {Title}");
            System.Console.WriteLine($"Genres:   {string.Join(",", Genres)}");
            Console.WriteLine();

        }

       
    }
}
