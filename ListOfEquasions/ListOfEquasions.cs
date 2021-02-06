using System;

namespace ListOfEquasions
{
    class ListOfEquasions
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = x * y;
            while (x < 11 && y < 11)
            {
                y = ++y;
                if (y % 11 == 0)
                {
                    x = ++x;
                    y = y - 10;
                    if (x == 11)
                    {
                        break;
                    }
                }
                z = x * y;
                Console.WriteLine(x + "x" + y + "=" + z);
            }
        }
    }
}