using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 1; i <= input; i++)
            {
                list.Add(i);
            }
            Console.Clear();
            Random rnd = new Random();
            List<int> rList = new List<int>(list.OrderBy(item => rnd.Next()));

            int tmp;
            void Print()
            {
                foreach (int value in rList)
                {
                    for (int i = 0; i < rList[value - 1]; i++)
                    {
                        Console.Write("■");
                    }
                    Console.WriteLine();
                }
            }
            Print();
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                for(int str = 1; str < input; str++)
                {
                    Console.Clear();
                    for (int num = 0; num < input-1; num++)
                    {
                        if (rList[num] == str)
                        {
                            tmp = rList[str-1];
                            rList[str-1] = rList[num];
                            rList[num] = tmp;
                        }
                    }
                    Print();
                    Thread.Sleep(50);
                }
            }

            Console.ReadKey();
        }
    }
}
