using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

//Divisible Sum Pairs - Hacker Rank

namespace Run
{
    class Program
    {

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {

            var map = new Dictionary<int, int>();

            //Counts how many sights every bird type has
            foreach (int birdId in arr)
            {
                if (!map.ContainsKey(birdId))
                {
                    map.Add(birdId, 1);
                }
                else
                {
                    map[birdId]++;
                }
            }

            List<KeyValuePair<int, int>> map_list = map.ToList();

            // Sort by Value in descendent order
            map_list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            int i = 0;
            int min_bird = map_list.ElementAt(i).Key; // assign the first value as default birdID fro compare
            int max_count_bird = map_list.ElementAt(i).Value; //assign max value of sights

            //Finds the min birdID with the higher value of sights
            while(map_list.ElementAt(i).Value == max_count_bird){ //iterates for the first N positions that had the same max value of sights
                if(map_list.ElementAt(i).Key < min_bird){ //check if was found a lower birdID
                    min_bird = map_list.ElementAt(i).Key;
                }
                i++;
            }

            return min_bird;
        }

        static void Main(string[] args)
        {

            //List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            List<int> arr = new List<int> { 1, 4, 4, 4, 5, 3};

            int result = migratoryBirds(arr);

            Console.Write(result);
        }
    }
}
