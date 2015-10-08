using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många noder på vänstra sidan? ");
            int leftNodes = int.Parse(Console.ReadLine());
            Console.Write("Hur många noder på högra sidan? ");
            int rightNodes = int.Parse(Console.ReadLine());
            Form1 fo = new Form1(leftNodes, rightNodes);
            fo.ShowDialog();
        }
    }
}
