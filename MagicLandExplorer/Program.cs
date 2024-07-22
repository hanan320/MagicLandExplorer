using System;
using System.Collections.Generic;
using System.IO;
using MagicLandExplorer.Task;
using Newtonsoft.Json;


namespace MagicLandExplorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, "../../../data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            // Define a dictionary of actions (delegates) corresponding to different tasks.
            var menuOptions = new Dictionary<int, Action<List<Category>>>
            {
                { 1, FilterDestinations.ShowFilteredDestinations },
                { 2, LongestDuration.ShowLongestDuration },
                { 3, SortByName.ShowSortedDestinations },
                { 4, Top3Duration.ShowTop3Destinations },
                { 5, SharedLocation.ShowSharedLocationCategories }
            };

            while (true)
            {
                // Display the menu options to the user.
                DisplayMenu();

                var input = Console.ReadLine();

                // Try to parse the user input as an integer.
                if (int.TryParse(input, out int choice))
                {
                    // If the user chooses to exit, break the loop.
                    if (choice == 6) break;

                    // If the choice is valid, invoke the corresponding action.
                    if (menuOptions.ContainsKey(choice))
                    {
                        menuOptions[choice](categories);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Magic Land Explorer:");
            Console.WriteLine("1 - Show filtered destinations");
            Console.WriteLine("2 - Show longest duration");
            Console.WriteLine("3 - Sort destinations by name");
            Console.WriteLine("4 - Show top 3 longest durations");
            Console.WriteLine("5 - Show categories with 'Fantasyland' as a shared location");
            Console.WriteLine("6 - Exit");


        }
    
     }
}
