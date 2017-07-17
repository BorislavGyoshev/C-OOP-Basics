namespace P04_OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            int minutes = 0;
            int seconds = 0;
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                try
                {
                    if (!Regex.IsMatch(inputLine, @"([0-9]+:[0-9]+)"))
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                    string[] input = inputLine.Split(new[] { ';', ':' });
                    string name = input[0];
                    string artist = input[1];
                    minutes = int.Parse(input[2]);
                    seconds = int.Parse(input[3]);

                    songs.Add(new Song(name, artist, minutes, seconds));
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine($"Songs added: {songs.Count()}");
            int hours = 0;
            minutes = 0;
            seconds = 0;
            foreach (var song in songs)
            {
                if ((seconds + song.Seconds) > 59)
                {
                    minutes++;
                    seconds = (seconds + song.Seconds) % 60;
                }
                else
                {
                    seconds += song.Seconds;
                }
                if ((minutes + song.Minutes) > 59)
                {
                    hours++;
                    minutes = (minutes + song.Minutes) % 60;
                }
                else
                {
                    minutes += song.Minutes;
                }
            }
            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
