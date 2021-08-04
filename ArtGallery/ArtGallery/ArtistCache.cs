using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    class ArtistCache
    {
        private Artist artists;
        private string albumName;
        private List<AlbumImage> albumImage;
        private List<AlbumButton> albumButton;



        public static string Apodo { get; set; }
        public static string Nombre { get; set; }
        public static string Fecha { get; set; }
        public static string  Email{ get; set; }
        public static string Password { get; set; }
        public static string PathImage { get; set; }
        public static bool Bandera { get; set; }


        public ArtistCache(string albumName)
        {
            LoadArtist();
            this.albumName = albumName;
        }


        //ADD REMOVE WRITE LOAD para el Artista
        public void LoadArtist() {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    artists = (Artist)bin.Deserialize(stream);
                    ArtistCache.Nombre = artists.Nombre;
                    ArtistCache.Apodo = artists.Apodo;
                    ArtistCache.Email = artists.Email;
                    ArtistCache.Fecha = artists.Fecha;
                    ArtistCache.Password = artists.Password;
                    ArtistCache.PathImage = artists.ImagePath;

                }
            }
            catch (FileNotFoundException)
            {
                artists = new Artist("NotYet","","","");
                ArtistCache.Nombre =  artists.Nombre;
                ArtistCache.Apodo  =  artists.Apodo;
                ArtistCache.Email  =  artists.Email;
                ArtistCache.Fecha  =  artists.Fecha;
                ArtistCache.PathImage = artists.ImagePath;
                ArtistCache.Password = artists.Password;
            }
            catch (IOException)
            {

            }
        }

        public void WriteInFile()
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {

                    artists.Nombre = ArtistCache.Nombre;
                    artists.Apodo =  ArtistCache.Apodo;
                    artists.Email =  ArtistCache.Email ;
                    artists.Fecha = ArtistCache.Fecha ;
                    artists.Password = ArtistCache.Password;
                    artists.ImagePath = ArtistCache.PathImage;
                  

                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, artists);

                }
            }
            catch (IOException) { }
        }




        //ADD REMOVE WRITE LOAD pa las Imagenes
        public List<AlbumImage> LoadImage(string album)
        {
            try
            {
                using (Stream stream = File.Open(album+".bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    albumImage = (List<AlbumImage>)bin.Deserialize(stream);
                    return albumImage;
                }
            }
            catch (FileNotFoundException)
            {
                albumImage = new List<AlbumImage>();
                return new List<AlbumImage>();
            }
            catch (IOException)
            {
                albumImage = new List<AlbumImage>();
                return new List<AlbumImage>();
            }
        }

        public void WriteInFileImage()
        {
            try
            {
                using (Stream stream = File.Open(albumName+".bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, albumImage);
                }
            }
            catch (IOException) { }
        }


        public bool AddImage(AlbumImage newImage)
        {
            for (int i = 0; i < albumImage.Count; i++)
            {
                if (albumImage.ElementAt(i).PathImage == newImage.PathImage)
                    return false;
            }
            albumImage.Add(newImage);
            WriteInFileImage();
            return true;
        }
        public void RemoveImage(string Path)
        {
            for (int i = 0; i < albumImage.Count; i++)
            {
                if(albumImage.ElementAt(i).PathImage.Equals(Path))
                albumImage.RemoveAt(i);
                WriteInFileImage();
            }
        }

        public void EditRankig(int ranking, string Path)
        {
            for (int i = 0; i < albumImage.Count; i++)
            {
                if (albumImage.ElementAt(i).PathImage.Equals(Path))
                    albumImage.ElementAt(i).Rating = ranking;
                WriteInFileImage();
            }
        }
        public int geRanking(string Path)
        {
            
            for (int i = 0; i < albumImage.Count; i++)
            {
                if (albumImage.ElementAt(i).PathImage.Equals(Path))
                    return albumImage.ElementAt(i).Rating;
                }

            return -1;
        }




        //ADD REMOVE WRITE LOAD pa los Bottones
        public List<AlbumButton> LoadButton()
        {
            try
            {
                using (Stream stream = File.Open("Buttons.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    albumButton = (List<AlbumButton>)bin.Deserialize(stream);
                    return albumButton;
                }
            }
            catch (FileNotFoundException)
            {
                albumButton = new List<AlbumButton>();
                return new List<AlbumButton>();
            }
            catch (IOException)
            {
                albumButton = new List<AlbumButton>();
                return new List<AlbumButton>();
            }
        }


        public void WriteInFileButton()
        {
            try
            {
                using (Stream stream = File.Open("Buttons.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, albumButton);
                }
            }
            catch (IOException) { }
        }


        public bool AddButton(AlbumButton newButton)
        {
            for (int i = 0; i < albumButton.Count; i++)
            {
                if (albumButton.ElementAt(i).AlbumName == newButton.AlbumName)
                    return false;
            }
            albumButton.Add(newButton);
            WriteInFileButton();
            return true;
        }
        public void RemoveButton(string Path)
        {
            for (int i = 0; i < albumButton.Count; i++)
            {
                if (albumButton.ElementAt(i).AlbumName.Equals(Path))
                    albumButton.RemoveAt(i);
                WriteInFileButton();
            }
        }


    }
}
