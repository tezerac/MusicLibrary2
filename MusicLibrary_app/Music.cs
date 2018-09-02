using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_app
{
    class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public static Music GetMusic()
        {
            var music = new Music
            {
                Title = "selam",
                Artist = "Mohamud",
                Album = "Ethiopia"
            };
            return music;
        }
    }
}
