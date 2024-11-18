using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif1_v._2._0._0
{
    internal class Grid
    {
        public const int GRID_SIZE = 10;
        public static int posX = 5;
        public static int posY = 5;

        public static void MoveUp()
        {
            if (posY > 0)
            {
                posY--;
            }
        }

        public static void MoveDown()
        {
            if (posY < GRID_SIZE)
            {
                posY++;
            }
        }

        public static void MoveLeft()
        {
            if (posX > 0)
            {
                posX--;
            }
        }

        public static void MoveRight()
        {
            if (posX < GRID_SIZE)
            {
                posX++;
            }
        }
    }
}
