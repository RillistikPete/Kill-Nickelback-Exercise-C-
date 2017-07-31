using System;
using System.Collections.Generic;

namespace kill_nickelback
{
    class Program
    {
        static void Main()
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            
            HashSet<(string Name, string Artist)> allSongs = new HashSet<(string Name, string Artist)>();
                allSongs.Add(("Savin' Me", "Nickelback"));
                allSongs.Add(("ASong", "AnotherArtist"));
                allSongs.Add(("Photograph", "Nickelback"));
                allSongs.Add(("Far Away", "Nickelback"));
                allSongs.Add(("Gong", "Another"));
                allSongs.Add(("G", "Artist4"));
                allSongs.Add(("Ng", "Artist1"));
            
                //Prints out Nickelback songs, and adds good songs that aren't Nickelback
                // songs to List goodSongs
                
                foreach(var i in allSongs){
                    if (i.Artist == "Nickelback")
                    {
                        Console.WriteLine($"{i}");
                    }
                    if (i.Artist != "Nickelback")
                    {
                        goodSongs.Add(i);
                    }
                }

                //Prints out all the good songs

                foreach(var j in goodSongs){
                    Console.WriteLine($"{j}");
                }


        }
    }
}

