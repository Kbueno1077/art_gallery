using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    [Serializable()]
    class AlbumImage
    {

        public  string  AlbumName { get; set; }
        public  string  PathImage { get; set; }
        public  int     Rating { get; set; }

        public AlbumImage(string AlbumName, string PathImage)
        {
            this.AlbumName = AlbumName;
            this.PathImage = PathImage;
            this.Rating = 0;

        }


    }
}
