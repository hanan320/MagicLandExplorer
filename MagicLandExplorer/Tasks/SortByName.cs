using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Task
{
    public class SortByName
    {
        public static void ShowSortedDestinations(List<Category> categories)
        {
            // Flatten the list of destinations from all categories into a single list.
            var destinations = categories.SelectMany(c => c.Destinations);

            // Order the destinations alphabetically by their name.
            var sortedDestinations = destinations.OrderBy(d => d.Name).ToList();

            // Output the sorted destinations to the console.
            Console.WriteLine("Destinations sorted by name:");
            foreach (var destination in sortedDestinations)
            {
                // Display the name of each destination.
                Console.WriteLine(destination.Name);
            }
        }
    }
}
