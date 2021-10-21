using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, category Category, genre Genre, int Runtime, List<string> Scenes) : base(Title, Category, Genre, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            PrintScenes(this);
            int response = 0;
            try
            {
                Console.WriteLine("Please Pick a Scene by entering an index: ");
                response = int.Parse(Console.ReadLine());
                //Console.WriteLine(response);
                //this.PrintScenes(this);
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid index");
                response = 0;
                Play();
            }
            if (response > this.Scenes.Count)
            {
                Console.WriteLine("That was not a valid index");
                response = 0;
                Play();
            }
            else
            {
                Console.WriteLine($"Playing: {this.Title}\n");
                for (int i = response; i < this.Scenes.Count; i++)
                {
                    Console.WriteLine(this.Scenes[i]);
                }
            }

        }
    }
}
