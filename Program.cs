using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artist, string title)> goodSongs = new List<(string, string)>();

            HashSet<(string artist, string title )> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Wu-Tang Clan", "Protect Ya Neck"));
            allSongs.Add(("The Ramones", "Beat on the Brat"));
            allSongs.Add(("Nickleback", "Photograph"));
            allSongs.Add(("Nickleback", "Rockstar"));
            allSongs.Add(("Nickleback", "How You Remind Me"));
            allSongs.Add(("Tom Waits", "Jockey Full of Bourbon"));
            allSongs.Add(("Prince", "When Doves Cry"));

            Console.WriteLine("\nThese are all the songs.\n");
            
            foreach(var song in allSongs)
            {
                Console.WriteLine($"{song.artist} by {song.title}");
                
                if(song.artist != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }

            Console.WriteLine("\nThese are the good songs, because Nickleback sucks.\n");

            foreach(var tune in goodSongs)
            {
                Console.WriteLine($"{tune.artist} by {tune.title}");
            }
        }
    }
}
