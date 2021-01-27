using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outkast Aquemini
            Artist Outkast = new Artist();
            Outkast.Name = "Outkast";

            Song s1 = new Song();
            s1.Artist = Outkast;
            s1.Duration = 71f;
            s1.SongTitle = "Hold On, Be Strong";

            Song s2 = new Song();
            s2.Artist = Outkast;
            s2.Duration = 349f;
            s2.SongTitle = "Return of the 'G'";

            Song s3 = new Song();
            s3.Artist = Outkast;
            s3.Duration = 324f;
            s3.SongTitle = "Rosa Parks";

            Release aq = new Release();
            aq.ReleaseDate = new DateTime(1998, 9, 29, 9, 0, 0);
            aq.ReleaseTitle = "Aquemni";
            aq.thisArtist = Outkast;
            aq.thisGenre = Genre.Rap;
            aq.thisReleaseType = ReleaseType.Album;
            aq.SongsInRelease.Add(s1);
            aq.SongsInRelease.Add(s2);
            aq.SongsInRelease.Add(s3);

            // Pink Floyd - Dark Side of the Moon
            Artist PinkFloyd = new Artist();
            Outkast.Name = "Pink Floyd";

            Song sp1 = new Song();
            sp1.Artist = PinkFloyd;
            sp1.Duration = 73f;
            sp1.SongTitle = "Speak to Me";

            Song sp2 = new Song();
            sp2.Artist = PinkFloyd;
            sp2.Duration = 163f;
            sp2.SongTitle = "Breathe";

            Song sp3 = new Song();
            sp3.Artist = PinkFloyd;
            sp3.Duration = 216f;
            sp3.SongTitle = "Speak to Me";

            Release pfd = new Release();
            pfd.ReleaseDate = new DateTime(1973, 3, 1, 9, 0, 0);
            pfd.ReleaseTitle = "Dark Side of the Moon";
            pfd.thisArtist = PinkFloyd;
            pfd.thisGenre = Genre.Rock;
            pfd.thisReleaseType = ReleaseType.Album;
            pfd.SongsInRelease.Add(sp1);
            pfd.SongsInRelease.Add(sp2);
            pfd.SongsInRelease.Add(sp3);


            Playlist myPlaylist = new Playlist();
            myPlaylist.ReleaseList.Add(pfd);
            myPlaylist.ReleaseList.Add(aq);
            Console.ReadLine();

        }
    }
}
