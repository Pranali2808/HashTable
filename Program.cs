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
            int key = 0;
            string paragraphPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = paragraphPhrase.Split(' ');
            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraph.Length);
            foreach (string word in paragraph)
            {
                myMapNode.Add(key, word);
                key++;
            }
              Console.WriteLine("frequency of words ");
             myMapNode.Display();
                    Console.ReadLine();
        }
    }
}