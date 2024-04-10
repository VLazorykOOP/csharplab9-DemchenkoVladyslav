using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class MusicCatalog
    {
        private Hashtable catalog;

        public MusicCatalog()
        {
            catalog = new Hashtable();
        }

        public void AddDisk(string title)
        {
            MusicDisk disk = new MusicDisk(title);
            catalog.Add(title, disk);
        }

        public void RemoveDisk(string title)
        {
            catalog.Remove(title);
        }

        public void AddSongToDisk(string diskTitle, string songTitle, string artist)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                MusicDisk disk = (MusicDisk)catalog[diskTitle];
                disk.AddSong(songTitle, artist);
            }
            else
            {
                Console.WriteLine($"Музичний диск '{diskTitle}' не знайдено.");
            }
        }

        public void RemoveSongFromDisk(string diskTitle, string songTitle)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                MusicDisk disk = (MusicDisk)catalog[diskTitle];
                disk.RemoveSong(songTitle);
            }
            else
            {
                Console.WriteLine($"Музичний диск '{diskTitle}' не знайдено.");
            }
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Каталог музичних дисків:");
            foreach (DictionaryEntry diskEntry in catalog)
            {
                MusicDisk disk = (MusicDisk)diskEntry.Value;
                disk.DisplayContents();
            }
        }

        public void SearchByArtist(string artist)
        {
            Console.WriteLine($"Пісні виконавця '{artist}':");
            foreach (DictionaryEntry diskEntry in catalog)
            {
                MusicDisk disk = (MusicDisk)diskEntry.Value;
                if (disk.ContainsArtist(artist))
                {
                    Console.WriteLine($"Музичний диск '{diskEntry.Key}':");
                    foreach (DictionaryEntry songEntry in disk.songs)
                    {
                        Song song = (Song)songEntry.Value;
                        if (song.Artist.Equals(artist))
                            Console.WriteLine(song);
                    }
                }
            }
        }
    }
       
}
