using System;

namespace HalloweenSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("20 3 6 80");
            int x = howManyGames(20, 3, 6, 80);
            Console.WriteLine($"{x}");

            //Console.WriteLine("16 2 1 9981");
            //int x = howManyGames(16, 2, 1, 9981);
            //Console.WriteLine($"{x}");

            //Console.WriteLine("100 1 1 99");
            //int x = howManyGames(100, 1, 1, 99);
            //Console.WriteLine($"{x}");
        }

        static int howManyGames(int p, int d, int m, int s)
        {
            int t = s;
            int newp = p;
            int rnum = 0;

            while(t >= newp)
            {
                if(newp == m)
                {
                    rnum++;
                    t = t - m;
                }
                else
                {
                    rnum++;
                    t = t - newp;

                    if(newp - d < m)
                    {
                        newp = m;
                    }
                    else
                    {
                        newp = newp - d;
                    }
                }
            }
            return rnum;
        }
    }
}

// p = price of game
// d = discount price
// m = minimum price
// s = total money
