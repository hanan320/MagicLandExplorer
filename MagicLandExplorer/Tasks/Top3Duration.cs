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
          
            var destinations = categories.SelectMany(c => c.Destinations);

         
            var top3Destinations = destinations.OrderByDescending(d => d.GetDurationInMinutes()).Take(3).ToList();

         
            Console.WriteLine("Top 3 longest-duration destinations:");

            foreach (var destination in top3Destinations)
            {
                Console.WriteLine($"{destination.Name} ({destination.GetDurationInMinutes()} minutes)");
            }
        }
    }
}
