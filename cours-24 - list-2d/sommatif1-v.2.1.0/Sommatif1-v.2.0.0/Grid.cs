using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif1_v._2._0._0
{
    internal class Grid
    {
        public static char[,] tiles = {
            { '█','█','█','█','█','█','█','█','█','█','█','█','█'},
            { '█',' ',' ',' ','█',' ',' ',' ','█',' ',' ',' ','█'},
            { '█','█','█',' ','█',' ','█',' ',' ',' ','█',' ','█'},
            { '█',' ','█',' ','█','█','█','█','█','█','█',' ','█'},
            { '█',' ',' ',' ',' ',' ',' ',' ',' ','█',' ',' ','█'},
            { '█',' ','█','█','█','█','█',' ',' ','█','█',' ','█'},
            { '█',' ','█',' ','█',' ',' ',' ','█','█',' ',' ','█'},
            { '█',' ','█',' ',' ',' ','█',' ',' ',' ',' ',' ','█'},
            { '█','█','█','█','█','█','█','█','█','█','█','█','█'}
        };
        public static int posX = 1;
        public static int posY = 1;

        public static void MoveUp()
        {
            if (posY > 0 && tiles[posY-1,posX] != '█')
            {
                posY--;
            }
        }

        public static void MoveDown()
        {
            if (posY < tiles.GetLength(0) && tiles[posY + 1, posX] != '█')
            {
                posY++;
            }
        }

        public static void MoveLeft()
        {
            if (posX > 0 && tiles[posY, posX-1] != '█')
            {
                posX--;
            }
        }

        public static void MoveRight()
        {
            if (posX < tiles.GetLength(1) && tiles[posY, posX + 1] != '█')
            {
                posX++;
            }
        }
    }
}
