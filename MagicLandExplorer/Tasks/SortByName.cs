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
           
            var destinations = categories.SelectMany(c => c.Destinations);

        
            var sortedDestinations = destinations.OrderBy(d => d.Name).ToList();

       
            Console.WriteLine("Destinations sorted by name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine(destination.Name);
            }
        }
    }
}
