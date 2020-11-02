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

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {

            int count_pairs = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var sum = ar[i] + ar[j];
                    if (sum % k == 0) //checks if (the sum) is divisible by k
                    {
                        count_pairs++;
                    }
                }
            }
            return count_pairs;
        }

        static void Main(string[] args)
        {

            int n = 2;
            int k = 2;

            int[] ar = new int[] {8,10};
            int result = divisibleSumPairs(n, k, ar);

            Console.Write(result);
            /*textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
