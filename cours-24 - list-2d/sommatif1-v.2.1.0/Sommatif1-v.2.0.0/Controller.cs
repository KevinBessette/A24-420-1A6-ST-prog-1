using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif1_v._2._0._0
{
    internal class Controller
    {

        public static void MainMenuController()
        {
            string input = "";
            while (input != "exit")
            {
                Console.Clear();
                ConsoleView.DrawGrid();
                ConsoleView.DisplayControlOptions();
                input = ConsoleView.ReadControl();
                if (input == "g")
                {
                    Grid.MoveLeft();
                }
                if (input == "d")
                {
                    Grid.MoveRight();
                }
                if (input == "h")
                {
                    Grid.MoveUp();
                }
                if (input == "b")
                {
                    Grid.MoveDown();
                }
            }
        }
    }
}
