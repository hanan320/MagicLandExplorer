using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

      
        public int GetDurationInMinutes()
        {
           
            if (string.IsNullOrEmpty(Duration)) return 0;

            var parts = Duration.Split(' ');

            if (parts.Length > 0 && int.TryParse(parts[0], out int result))
            {
                return result;
            }

            return 0;
        }

    }
}
