using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Library
{
    public class Video : MediaLibary
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }

        public override void Display()
        {
           
            Console.WriteLine();
            System.Console.WriteLine($"Video ID: {Id}");
            System.Console.WriteLine($"Title:    {Title}");
            System.Console.WriteLine($"Format:   {Format}");
            System.Console.WriteLine($"Length:   {Length}");
            System.Console.WriteLine($"Format:   {String.Join(",",Regions)}"); 
            Console.WriteLine();
        }
    }
}
