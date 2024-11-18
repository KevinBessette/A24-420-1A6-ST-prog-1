using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sommatif2_v2._0._0
{
    internal class Utilities
    {
        public static int ReadInteger()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception) {
                    Console.WriteLine("Valeur invalide");
                }
            }
        }

        public static string FormatTime(int timeInSeconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(timeInSeconds);
            return ts.ToString(@"mm\:ss");
        }
    }
}
