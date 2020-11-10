using System;
using System.Collections.Generic;

namespace Bill_Division
{
    class Program
    {

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int common = 0;
            for (int i = 0; i < bill.Count; i++)
            {

                if (i != k)
                {
                    common = common + bill[i];
                }
            }

            int actual = common/2;

            if (actual < b)
            {
                Console.WriteLine(b - actual);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }

        }

        static void Main(string[] args)
        {

            int k = 1; //0-based index of the item that Anna did not eat

            List<int> bill = new List<int> { 3, 10, 2, 9 }; // items price that Anna and Bill ate

            int b = 12; //amount of money that Brian charged Anna for her share of the bill.

            bonAppetit(bill, k, b);
        }
    }
}
