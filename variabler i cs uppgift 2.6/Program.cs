using System;
using System.Diagnostics;

namespace uppgift6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett tal"); // om du skriver decimal använd , och inte . !!!//
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett till tal");
            double y = double.Parse(Console.ReadLine());
            double medel = (x + y) / 2;
            Console.WriteLine("medelvärdet mellan dina två tal är " + medel);
        }
    }
}