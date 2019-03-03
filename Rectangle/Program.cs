using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");
            string length = Console.ReadLine();
            int parsedLength = int.Parse(length);
            
            // Get input from the user and save it to a variable.

            Console.Write("Enter the width of the rectangle: ");
            string width = Console.ReadLine();
            int parsedWidth = int.Parse(width);
            // Get input from the user and save it to a second variable.

            // Output - The area of the rectangle is (computed value)

            int area = (parsedWidth * parsedLength);
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
