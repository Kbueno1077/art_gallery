using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    [Serializable()]
    class Artist
    {

        public string Apodo { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
       


        public Artist(string Apodo, string Nombre, string fecha, string Email) {
            this.Apodo = Apodo;
            this.Nombre = Nombre;
            this.Fecha= fecha;
            this.Email = Email;
            this.Password = "";
            this.ImagePath = "";
          

        }

    }
}
