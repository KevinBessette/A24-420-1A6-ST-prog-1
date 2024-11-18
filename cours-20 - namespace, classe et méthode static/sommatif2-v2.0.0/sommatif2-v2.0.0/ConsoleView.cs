using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sommatif2_v2._0._0
{
    internal class ConsoleView
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("====== Playlist musicale ======");
            Console.WriteLine("1. Afficher la playlist");
            Console.WriteLine("2. Ajouter une chanson");
            Console.WriteLine("3. Supprimer une chanson");
            Console.WriteLine("4. Quitter");
            Console.WriteLine("===============================");
            Console.Write("\n");
        }

        public static void DisplayPlaylist()
        {
            for (int i = 0; i < Playlist.titles.Count; i++)
            {
                Console.WriteLine($"#{i+1}. {Playlist.bands[i]} - {Playlist.titles[i]} - {Utilities.FormatTime(Playlist.timesInSeconds[i])}");
            }
            Console.WriteLine($"Il y a {Playlist.titles.Count} chanson pour une durée total de : {Utilities.FormatTime(Playlist.totalTime)}");
            Console.Write("\n");
        }

        public static string ReadNewTitle()
        {
            Console.WriteLine("Inscrivez le titre de la nouvelle chanson:");
            return Console.ReadLine();
        }
        public static string ReadNewBand()
        {
            Console.WriteLine("Inscrivez le nom du groupe de la nouvelle chanson:");
            return Console.ReadLine();
        }
        public static int ReadNewTime()
        {
            Console.WriteLine("Inscrivez la durée en seconde de la nouvelle chanson:");
            return Utilities.ReadInteger();
        }

        public static int ReadPositionToRemove() {
            Console.WriteLine("Inscrivez la position de la chanson que vous voulez supprimer");
            return Utilities.ReadInteger() - 1;

        }
    }
}
