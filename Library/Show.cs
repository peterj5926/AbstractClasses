using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Library
{
    public class Show : MediaLibary
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }

        public override void Display()
        {
           
            Console.WriteLine();
            System.Console.WriteLine($"Show ID: {Id}");
            System.Console.WriteLine($"Title:   {Title}");
            System.Console.WriteLine($"Season:  {Season}");
            System.Console.WriteLine($"Episode: {Episode}");
            System.Console.WriteLine($"Writer:  {string.Join(",", Writers)}");
            Console.WriteLine();
        }
    }
}
