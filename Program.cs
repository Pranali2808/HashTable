using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Hash table program");
            MapNode<string, int> myMapNode = new MapNode<string, int>(6);
            string[] words = { "to", "be", "or", "not", "to", "be" };
            int count = 1;
            foreach (string i in words)
            {
                count = myMapNode.CheckHash(i);
                if (count > 1)
                {
                    myMapNode.Add(i,count);
                }
                else
                {
                    myMapNode.Add(i,1);
                }
            }
               IEnumerable<string> uniqueItems = words.Distinct<string>();
            foreach (var i in uniqueItems)
            {
                myMapNode.Display(i);
            }
            Console.ReadLine();
        }
    }
}