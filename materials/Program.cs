using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double woodlength = 0;
            double glassarea = 0;
            const double Max_Width = 5.0;
            const double Min_Width = 0.5;
            const double Max_Height = 3.0;
            const double Min_Height = 0.75;
            Console.Write("Input window width: ");
            string widthString = Console.ReadLine();
            double width = double.Parse(widthString);
            if (width < Min_Width)
            {
                Console.WriteLine($"Width is too small \n\n Use {Min_Width}");
                width = Min_Width;

            }
            else if (width > Max_Width) 
            {
                Console.WriteLine($"Width is too large. \n\n Use {Max_Width}");
                width = Max_Width;
            }
            Console.Write("Input window height: ");
            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);
            if (height < Min_Height) 
            {
                Console.WriteLine($"Height is too small. \n\n Use {Min_Height}");
                height = Min_Height;
            }
            else if (height > Max_Height)
            {
                Console.WriteLine($"Height is too large. \n\n Use {Max_Height}");
                height = Max_Height;
            }
            double Woodlength = 2 * (width * height) * 3.25;
            double Glassarea = 2 * (width * height);
            Console.WriteLine($"Length of the wood = {Woodlength} feet.");
            Console.WriteLine($"Area of glass = {Glassarea} square meters");
        }
    }
}
