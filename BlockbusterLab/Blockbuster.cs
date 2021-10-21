using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public Blockbuster()
        {
            //Create DVD Scenes
            List<string> DVD1scenes = new List<string>();
            DVD1scenes.Add("Jerry loses his money");
            DVD1scenes.Add("Jerry starts looking for his money");
            DVD1scenes.Add("Jerry realizes that Big Corporation stole his money via online purchases");
            DVD1scenes.Add("Jerry confronts Big Corp and demands his money");
            DVD1scenes.Add("Big Corporation hold's Jerry's money for ransom");
            DVD1scenes.Add("Jerry demands proof of life");
            DVD1scenes.Add("Jerry pays the ransom and gets his money");
            DVD1scenes.Add("Everybody asks Jerry to show them the money");

            List<string> DVD2scenes = new List<string>();
            DVD2scenes.Add("Voldemort sets up a moon base");
            DVD2scenes.Add("Harry becomes headmaster of Hogwarts");
            DVD2scenes.Add("Harry realizees something funny is happening on the moon");
            DVD2scenes.Add("Voldemort attacks the earth with magical moon cheese");
            DVD2scenes.Add("Harry just now realizes that Voldemort is alive");
            DVD2scenes.Add("Harry learns that Voldemort has been posing as Ginny for their entire marriage");
            DVD2scenes.Add("Voldemort takes Harry to court");
            DVD2scenes.Add("Harry loses the house and all of his wands");
            DVD2scenes.Add("Voldemort remarries and lives off Harry's alimony payments");
            DVD2scenes.Add("Harry is not able to pay");
            DVD2scenes.Add("Harry is imprisoned on the debtors prison");
            DVD2scenes.Add("The prison is on the moon");

            List<string> DVD3scenes = new List<string>();
            DVD3scenes.Add("Something");
            DVD3scenes.Add("Something");
            DVD3scenes.Add(".");
            DVD3scenes.Add(".");
            DVD3scenes.Add(".");
            DVD3scenes.Add(".");
            DVD3scenes.Add("DANGERZOOOONE");


            //Create VHS Scenes
            List<string> VHS1scenes = new List<string>();
            VHS1scenes.Add("Rambo gets back from war");
            VHS1scenes.Add("Rambo is ready to ETS");
            VHS1scenes.Add("Rambo tries to turn in his weapon into the Armory");
            VHS1scenes.Add("Rambo's weapon is dirty so he has to try again");
            VHS1scenes.Add("Amrorer rejects the weapon again");
            VHS1scenes.Add("Amrorer rejects the weapon again");
            VHS1scenes.Add("Amrorer rejects the weapon again");
            VHS1scenes.Add("Amrorer rejects the weapon again");
            VHS1scenes.Add("Amrorer rejects the weapon again");
            VHS1scenes.Add("Rambo's weapon is finally accepted into the Arms room");
            VHS1scenes.Add("Rambo goes to CIF to turn in his TA-50");
            VHS1scenes.Add("CIF says his gear is dirty and makes him go to the wash point");
            VHS1scenes.Add("CIF refuses to take back some of Rambo's gear and forces him to pay for it");
            VHS1scenes.Add("Rambo is now 55 years old and still trying to turn in his gear");
            VHS1scenes.Add("Rambo get's stop lossed and shipped to Iraq");

            List<string> VHS2scenes = new List<string>();
            VHS2scenes.Add("Somebody ask's Smalls if he wants a Smore");
            VHS2scenes.Add("Smalls hasn't had anything yet");
            VHS2scenes.Add("Smalls can't have more of anything because he hasn't had anything");
            VHS2scenes.Add("Smalls kills somebody");
            VHS2scenes.Add("Smalls takes out a loan to flee the country");
            VHS2scenes.Add("Smalls is found years later, but is unable to repay the loan");
            VHS2scenes.Add("Smalls is sent to debtors prison on the moon");

            List<string> VHS3scenes = new List<string>();
            VHS3scenes.Add("Kids from the daycare next door launch paper airplanes into Barney's yard");
            VHS3scenes.Add("Barney gathers a coalition of the willing");
            VHS3scenes.Add("Barney convinces congress that the other daycare has weapons of mass destruction");
            VHS3scenes.Add("The public isn't sold");
            VHS3scenes.Add("Babybop gets up and explains that the other daycare is a threat to our way of life");
            VHS3scenes.Add("Public opinion has been swayed and the war has been approved");
            VHS3scenes.Add("Barney is now elected president");
            VHS3scenes.Add("Barney takes out a loan from the World Bank");
            VHS3scenes.Add("Barney cannot pay back the loan");
            VHS3scenes.Add("Barney is locked up in the Federal Reserve");
            VHS3scenes.Add("The Federal Reserve is the name of the debtors prison");
            VHS3scenes.Add("It's on the moon");
            //ADD DVDs
            Movies.Add(new DVD("Jerry Brockovich: Show me the evil corporations", Movie.category.NonFiction, Movie.genre.Horror, 400, DVD1scenes));
            Movies.Add(new DVD("Harry Potter 12: Harry goes to the Moon", Movie.category.NonFiction, Movie.genre.Drama, 300, DVD2scenes));
            Movies.Add(new DVD("Archer and the Dangerzone", Movie.category.Fiction, Movie.genre.Action, 120, DVD3scenes));

            //ADD VHS
            Movies.Add(new VHS("Rambo gets out of the Army", Movie.category.NonFiction, Movie.genre.Action, 180,VHS1scenes,1));
            Movies.Add(new VHS("The Sandlot 12: Smalls goes to the moon", Movie.category.Fiction, Movie.genre.Comedy, 120, VHS2scenes, 2));
            Movies.Add(new VHS("Barney and Pals go to war", Movie.category.Fiction, Movie.genre.Romance, 89, VHS3scenes,2));

        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine(i + ") " + Movies[i].Title);
            }
        }

        public Movie CheckOut()
        {
            //List<Movie> m = new List<Movie>();
            int response = 0;
            Movie m = Movies[0];
            PrintMovies();
            Console.WriteLine();
            Console.Write("Enter the index of the Movie you would like to Check Out: ");
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid index, please try again");
                CheckOut();
            }
            
            try
            {
                m = Movies[response];
                m.PrintInfo(m);
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That was not a valid index");
                CheckOut();
            }
            return m;
        }
    }
}
