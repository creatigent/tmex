using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static char [,] arr = new char [3,3] { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };
        static int player = 1;

        static void Main(string[] args)
        {
            Console.Clear();
            Board();
        
            while (true)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                var i1 = int.Parse(data[0]) -1;
                var i2 = int.Parse(data[1]) -1;

                if(player % 2 == 0)
                {
                    arr[i1, i2] = 'X';
                    Board();
                    player++;
                }
                else
                {
                    arr[i1, i2] = 'O';
                    Board();
                    player++;
                }

                Console.WriteLine();
            }
        }

        private static void Board()
        {
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}", arr[i, j]);
                    if(j!=2)
                        Console.Write(",");
                }
                Console.WriteLine();
            }
        }
    }
}
