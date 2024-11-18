namespace sommatif2_v2._0._0
{
    internal class Controller
    {
        public static void MainMenuController()
        {
            int input = 0;
            while (input != 4)
            {
                ConsoleView.DisplayMenu();
                input = Utilities.ReadInteger();
                Console.Clear();
                switch (input)
                {
                    case 1:
                        ConsoleView.DisplayPlaylist();
                        break;
                    case 2:
                        Playlist.Add(ConsoleView.ReadNewTitle(), ConsoleView.ReadNewBand(), ConsoleView.ReadNewTime());
                        break;
                    case 3:
                        Playlist.Remove(ConsoleView.ReadPositionToRemove());
                        break;
                    default:
                        Console.WriteLine("Options inexistante");
                        break;
                }
            }
            
        }
    }
}
