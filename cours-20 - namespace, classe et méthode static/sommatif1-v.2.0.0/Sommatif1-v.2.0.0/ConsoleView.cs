using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif1_v._2._0._0
{
    internal class ConsoleView
    {
        public static void DrawGrid()
        {
            for (int y = 0; y < Grid.GRID_SIZE; y++)
            {
                for (int x = 0; x < Grid.GRID_SIZE; x++)
                {
                    if (x == Grid.posX && y == Grid.posY)
                        Console.Write("X");
                    else
                        Console.Write(".");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void DisplayControlOptions()
        {
            Console.WriteLine("====== Déplacer le X en écrivant [g]auche, [d]roite, [h]aut, [b]as ou [exit] pour quitter ======");
        }

        public static string ReadControl()
        {
            Console.WriteLine("Inscrivez une instruction: ");
            return Console.ReadLine();
        }
    }
}
