using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    internal class Playlist
    {
        public string Name { get; set; }
        public List<Songs> Songs { get; set; }

        public void AddSong(Songs song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Songs song)
        {
            Songs.Remove(song);
        }
    }
}
