using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Task
{
    public class LongestDuration
    {
        public static void ShowLongestDuration(List<Category> categories)
        {
            var longestDurationDestination = GetLongestDurationDestination(categories);

            DisplayLongestDurationDestination(longestDurationDestination);
        }

        private static Destination GetLongestDurationDestination(List<Category> categories)
        {
            return categories.SelectMany(c => c.Destinations)
                             .OrderByDescending(d => d.GetDurationInMinutes())
                             .FirstOrDefault();
        }

        public static void DisplayLongestDurationDestination(Destination destination)
        {
            Console.WriteLine("Destination with the longest duration:");

            if (destination != null)
            {
                Console.WriteLine($"{destination.Name} ({destination.GetDurationInMinutes()} minutes)");
            }
            else
            {
                Console.WriteLine("No destinations available.");
            }
        }
    }
}
