using System;
using System.Collections.Generic;

namespace probes_and_planets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Saturn", "Jupiter", "Uranus", "Neptune"};

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>("Viking I", "Mars"),
                new KeyValuePair<string, string>("Voyager I", "Venus"),
                new KeyValuePair<string, string>("Mariner I", "Jupiter"),
                new KeyValuePair<string, string>("Opportunity I", "Mars"),
                new KeyValuePair<string, string>("Curiosity I", "Venus"),
            };

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach(KeyValuePair<string, string> probe in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (probe.Value == planet){
                        matchingProbes.Add(probe.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {string.Join(" ", matchingProbes)}");
            };
        }
    }
}
