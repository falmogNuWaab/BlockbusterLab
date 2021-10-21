using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster video = new Blockbuster();
            Console.WriteLine("Welcome to the last Blockbuster Video on the Planet! Please don't go.");
            Console.WriteLine("Here are the available titles: ");
            Console.WriteLine();
            Movie rental = video.CheckOut();

            rental.Play();
        }
    }
}
