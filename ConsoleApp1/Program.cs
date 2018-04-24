using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GrandCircusRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            Console.Write("Enter length in ft: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width in ft: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height in ft: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area of the room: {length * width}" + " square feet");

            Console.WriteLine($"Perimeter of the room: {2 * length + 2 * width}" + " feet");

            Console.WriteLine($"Volume of the room: {length * width * height}" + " cube feet");
        }
    }
}
 
