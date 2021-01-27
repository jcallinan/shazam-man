using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Song
    {
        private string _songTitle;
        private Artist _artist;
        private float _duration;
        
        public string SongTitle { get => _songTitle; set => _songTitle = value; }
        public float Duration { get => _duration; set => _duration = value; }
        internal Artist Artist { get => _artist; set => _artist = value; }
    }
}
