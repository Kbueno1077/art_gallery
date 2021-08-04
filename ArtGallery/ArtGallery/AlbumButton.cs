using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{


    [Serializable()]
    class AlbumButton
    {

        public string AlbumName { get; set; }
       
        public AlbumButton(string AlbumName)
        {
            this.AlbumName = AlbumName;


        }
    }
}

