using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Movie
    {
        public string Title { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }  = new List<string>();
        public enum category { Fiction,NonFiction };
        public category Category { get; set; }
        public enum genre { Drama,Comedy,Horror,Romance,Action };
        public genre Genre { get; set; }

        public Movie(string Title, category Category, genre Genre, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
            this.Genre = Genre;
        }

        public void PrintScenes(Movie movie)
        {
            
            for(int i = 0; i < movie.Scenes.Count; i++)
            {
                Console.WriteLine(i + ") " + movie.Scenes[i]);
            }
        }

        public virtual void PrintInfo(Movie movie)
        {
            Console.WriteLine("");
            string response = $"Title: {movie.Title}\n";
            response += $"Category: {movie.Category}\n";
            response += $"Genre: {movie.Genre}\n";
            response += $"Runtime: {movie.Runtime}";
            Console.WriteLine(response);
        }

        // this was very interesting. I am guessing that since I'm calling these methods from an instance of an object that "this" represents the object I created
        // "this." refers to the "video" variable in Program.cs?
        public virtual void Play()
        {
            Console.WriteLine($"Playing: {this.Title}\n");
            for(int i = 0; i < this.Scenes.Count; i++)
            {
                Console.WriteLine(this.Scenes[i]);
            }
        }

    }
}
