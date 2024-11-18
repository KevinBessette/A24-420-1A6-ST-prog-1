namespace sommatif2_v2._0._0
{
    internal class Playlist
    {
        public static List<string> titles = ["Master of puppets", "Enter Sandman", "Adam song", "American psycho", "Sonne", "Falling away from me", "The chariot"];
        public static List<string> bands = ["Metallica", "Metallica", "Blink 182", "Treble charger", "Ramstein", "Korn", "The Cat empire"];
        public static List<int> timesInSeconds = [173, 658, 425, 162, 124, 325, 351, 458];
        public static int totalTime = timesInSeconds.Sum();

        public static void Add(string newTitle, string newBand, int newTime)
        {
            titles.Add(newTitle);
            bands.Add(newBand);
            timesInSeconds.Add(newTime);
            totalTime = timesInSeconds.Sum();
        }

        public static void Remove(int pos)
        {
            titles.RemoveAt(pos);
            bands.RemoveAt(pos);
            timesInSeconds.RemoveAt(pos);
            totalTime = timesInSeconds.Sum();
        }
    }
}
