using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class Task4
    {
       public async Task Run()
        {
            Console.WriteLine("Task 4");
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("Best Hits");
            catalog.AddSongToDisk("Best Hits", "Song 1", "Artist 1");
            catalog.AddSongToDisk("Best Hits", "Song 2", "Artist 2");

            catalog.AddDisk("Favorites");
            catalog.AddSongToDisk("Favorites", "Song 3", "Artist 1");
            catalog.AddSongToDisk("Favorites", "Song 4", "Artist 3");

            catalog.DisplayCatalog();

            catalog.SearchByArtist("Artist 1");
        }
    }
}
