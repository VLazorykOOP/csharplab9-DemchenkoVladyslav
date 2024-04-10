using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    class MusicDisk
    {
        private string title;
        public Hashtable songs;

        public MusicDisk(string title)
        {
            this.title = title;
            songs = new Hashtable();
        }

        public void AddSong(string title, string artist)
        {
            Song song = new Song(title, artist);
            songs.Add(title, song);
        }

        public void RemoveSong(string title)
        {
            songs.Remove(title);
        }

        public void DisplayContents()
        {
            Console.WriteLine($"Музичний диск: {title}");
            foreach (DictionaryEntry songEntry in songs)
            {
                Song song = (Song)songEntry.Value;
                Console.WriteLine(song);
            }
        }

        public bool ContainsArtist(string artist)
        {
            foreach (DictionaryEntry songEntry in songs)
            {
                Song song = (Song)songEntry.Value;
                if (song.Artist.Equals(artist))
                    return true;
            }
            return false;
        }
    }
}
