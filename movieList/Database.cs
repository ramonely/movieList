using System;
using System.Collections.Generic;
using System.Text;

namespace movieList
{
    internal class Database
    {
        public List<Movie> Films { get; set; } = new List<Movie>();

        public Database()
        {
            Films.Add(new Movie("Movie 1", "Animated"));
            Films.Add(new Movie("Movie 2", "Animated"));
            Films.Add(new Movie("Movie 3", "Drama"));
            Films.Add(new Movie("Movie 4", "Horror"));
            Films.Add(new Movie("Movie 5", "Animated"));
            Films.Add(new Movie("Movie 6", "Scifi"));
            Films.Add(new Movie("Movie 7", "Horror"));
            Films.Add(new Movie("Movie 8", "Horror"));
            Films.Add(new Movie("Movie 9", "Drama"));
            Films.Add(new Movie("Movie 10", "Scifi"));
        }

        public string Welcome()
        {
            Console.WriteLine("\t Welcome to the Movie List Application!\n");
            Console.WriteLine("\tThere are 10 Movies in the application!\n  \n   Pick a Category to see the movies under each group:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("      [1] Horror [2] Animated [3] Scifi [4] Drama");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("      Enter 1, 2, 3 or 4 to select Category above: ");
            string answer = Console.ReadLine();
            bool check = true;

            while (check)
            {
                if (answer == "1")
                {
                    string result = "horror";
                    check = false;
                    return result;
                }
                else if (answer == "2")
                {
                    string result = "animated";
                    check = false;
                    return result;
                }
                else if (answer == "3")
                {
                    string result = "scifi";
                    check = false;
                    return result;
                }
                else if (answer == "4")
                {
                    string result = "drama";
                    check = false;
                    return result;
                }
                else
                {
                    Console.WriteLine("Please only enter a number from 1 to 4:");
                    answer = Console.ReadLine();
                }
            }
            return answer;
        }

        public void loop()

        {
            Console.WriteLine("\nDo you want to search another category? (Enter y/n)");
            string checking = Console.ReadLine().ToLower();
            bool safe = true;

            while (safe)
            {
                if (checking == "y")
                {
                    Console.WriteLine();
                    string answer = Welcome();
                    lookUp(answer);
                    safe = false;
                }
                else if (checking == "n")

                {
                    Console.WriteLine("\nThanks for coming by!");
                    safe = false;
                }
                else
                {
                    Console.WriteLine("Please only enter: y/n");
                    checking = Console.ReadLine();
                }
            }
        }

        public void lookUp(string answer)
        {
            for (int i = 0; i < Films.Count; i++)
            {
                Movie watch = Films[i];
                if (watch.Category.Contains(answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\t\t\t{watch.Title}");
                }
            }
            loop();
        }
    }
}