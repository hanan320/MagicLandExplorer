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
            var fantasylandDestinations = from category in categories
                                          from destination in category.Destinations
                                          where destination.Location == "Fantasyland"
                                          select destination;

          
            Console.WriteLine("Destinations located in 'Fantasyland':");

            foreach (var destination in fantasylandDestinations)
            {
                Console.WriteLine(destination.Name);
            }
        }
    }
}
