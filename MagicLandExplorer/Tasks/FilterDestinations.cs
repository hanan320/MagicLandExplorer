using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Task
{
    public class FilterDestinations
    {
        public static void ShowFilteredDestinations(List<Category> categories)
        {
            var filteredDestinations = GetFilteredDestinations(categories, 100);

            DisplayDestinations(filteredDestinations);
        }

        public static List<Destination> GetFilteredDestinations(List<Category> categories, int maxDuration)
        {
            return categories.SelectMany(c => c.Destinations)
                             .Where(d => d.GetDurationInMinutes() < maxDuration)
                             .ToList();
        }

        public static void DisplayDestinations(List<Destination> destinations)
        {
            Console.WriteLine("Destinations with duration less than 100 minutes:");

            foreach (var destination in destinations)
            {
                Console.WriteLine(destination.Name);
            }
        }
    }
}
