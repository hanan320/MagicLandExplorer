using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Task
{
    public class SharedLocation
    {
        public static void ShowSharedLocationCategories(List<Category> categories)
        {
            // Filter destinations to get only those that are located in "Fantasyland".
            var fantasylandDestinations = from category in categories
                                          from destination in category.Destinations
                                          where destination.Location == "Fantasyland"
                                          select destination;

            // Output the filtered destinations to the console.
            Console.WriteLine("Destinations located in 'Fantasyland':");
            foreach (var destination in fantasylandDestinations)
            {
                // Display the name of each destination located in "Fantasyland".
                Console.WriteLine(destination.Name);
            }
        }
    }
}
