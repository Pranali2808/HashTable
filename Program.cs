using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        private static int counts;

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Hash table program");
            MapNode<string, int> myMap1 = new MapNode<string, int>(10);
            string[] paragraph1;
            string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            paragraph1 = input1.Split(' ');

            int count1 = 1;
            foreach (string i in paragraph1)
            {
                counts = myMap1.CheckHash(i);
                if (count1 > 1)
                {
                    myMap1.Add(i, counts);
                }
                else
                {
                    myMap1.Add(i, 1);
                }
            }
            IEnumerable<string> unique = paragraph1.Distinct<string>();
            Console.WriteLine("\nEnter the word which you want to remove in paragraph");
            string removeWord = Console.ReadLine();
            myMap1.Remove(removeWord);
            foreach (var i in unique)
            {
                myMap1.Display(i);
            }
            Console.ReadLine();
        }
    }
}