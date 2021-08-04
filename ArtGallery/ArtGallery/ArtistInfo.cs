using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class ArtistInfo : Form
    {

        ArtistCache AC = new ArtistCache("Info");
        string actualDir;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg,
            int wparam, int lparam);


        public ArtistInfo()
       {
            InitializeComponent();

            actualDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            actualDir += "\\Imagenes\\";


         

            try
            {
                datepicker.Value = DateTime.ParseExact(ArtistCache.Fecha, "MM-dd-yyyy", CultureInfo.InvariantCulture);
                txtApodo.Text = ArtistCache.Apodo;
                txtName.Text = ArtistCache.Nombre;
                txtEmail.Text = ArtistCache.Email;
            }
            catch (Exception) {
                datepicker.Value = DateTime.Now ;
                txtApodo.Text = "Nombre Artistico";
                txtName.Text =  "Nombre";
                txtEmail.Text = "Email";

            }

            try
            {
                txtPicture.Image = Image.FromFile(ArtistCache.PathImage);
            }
            catch (Exception) { }

            

        }
            
       private void LeftBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ArtistCache.Nombre = txtName.Text;
            ArtistCache.Apodo = txtApodo.Text;
            ArtistCache.Email = txtEmail.Text;
            ArtistCache.Fecha = datepicker.Value.ToString("MM-dd-yyyy");
            AC.WriteInFile();
            this.Close();
        }

       

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (txtName.Enabled == false)
                    txtName.Enabled = true;
                else txtName.Enabled = false;
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (datepicker.Enabled == false)
                datepicker.Enabled = true;
            else datepicker.Enabled = false;
        }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (txtApodo.Enabled == false)
                txtApodo.Enabled = true;
            else txtApodo.Enabled = false;
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (txtEmail.Enabled == false)
                txtEmail.Enabled = true;
            else txtEmail.Enabled = false;
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void TxtPicture_DoubleClick(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Busque una Imagen",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "jpg",
                
                Filter = "(*.png)|*.png| (*.jpg)| *.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                string Origen = openFile.FileName;
                string destino =  actualDir;

                File.Copy(Origen, Path.Combine(actualDir, Path.GetFileName(Origen)), true);
                ArtistCache.PathImage = Path.Combine(actualDir, Path.GetFileName(Origen));
                txtPicture.Image = Image.FromFile(ArtistCache.PathImage);

            }
        }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void TxtPicture_Click(object sender, EventArgs e)
        {

        }

        private void TxtApodo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
