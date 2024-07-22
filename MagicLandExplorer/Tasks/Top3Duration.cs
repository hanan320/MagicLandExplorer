using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Task
{
    public class Top3Duration
    {
        public static void ShowTop3Destinations(List<Category> categories)
        {
            // Flatten the list of destinations from all categories into a single list.
            var destinations = categories.SelectMany(c => c.Destinations);

            // Order the destinations by duration in descending order and take the top 3.
            var top3Destinations = destinations.OrderByDescending(d => d.GetDurationInMinutes()).Take(3).ToList();

            // Output the top 3 destinations with the longest durations to the console.
            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var destination in top3Destinations)
            {
                // Display the name and duration of each destination.
                Console.WriteLine($"{destination.Name} ({destination.GetDurationInMinutes()} minutes)");
            }
        }
    }
}
