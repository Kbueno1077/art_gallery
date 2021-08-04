using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class Autentificarse : Form
    {


        ArtistCache AC = new ArtistCache("Autentificarse");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg,
            int wparam, int lparam);

        public Autentificarse()
        {
            InitializeComponent();
        }

        private void BunifuMetroTextbox1_MouseDown(object sender, MouseEventArgs e)
        {



        }
        private void LeftBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {

            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.isPassword = true;
            }
        }


        private void Txtpass_Leave_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.isPassword = false;

            }
        }

    

        private void TxtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Nueva Contraseña")
            {
                txtNewPass.Text = "";
     
                txtNewPass.isPassword = true;
            }



        }

        private void TxtNewPass_Leave(object sender, EventArgs e)
        {

            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Nueva Contraseña";
               txtNewPass.isPassword = false;
            }


        }

        private void TxtRepNewPass_MouseEnter(object sender, EventArgs e)
        {

            if (txtRepNewPass.Text == "")
            {
                txtRepNewPass.Text = "Repetir Contraseña";
                txtRepNewPass.isPassword = false;
            }


        }

        private void TxtRepNewPass_MouseDown(object sender, EventArgs e)
        {
            if (txtRepNewPass.Text == "Repetir Contraseña")
            {
                txtRepNewPass.Text = "";
                 txtRepNewPass.isPassword = true;
            }
        }

        private void TxtActualPass_Enter(object sender, EventArgs e)
        {
            if (txtActualPass.Text == "Contraseña Actual")
            {
                txtActualPass.Text = "";
                txtActualPass.isPassword = true;
            }
        }

        private void TxtActualPass_Leave(object sender, EventArgs e)
        {
            if (txtActualPass.Text == "")
            {
                txtActualPass.Text = "Contraseña Actual";
                txtActualPass.isPassword = false;
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Password.Equals(""))
            {
                txtActualPass.Enabled = false;
            }

            this.Height = 430;
            txtNewPass.Text = "Nueva Contraseña";
            txtNewPass.isPassword = false;
            txtRepNewPass.Text = "Repetir Contraseña";
            txtRepNewPass.isPassword = false;
            txtActualPass.Text = "Contraseña Actual";
            txtActualPass.isPassword = false;

        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Height = 190;
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length > 4)
            {

                if (!txtRepNewPass.Text.Equals(""))
                {
                    if (txtNewPass.Text.Equals(txtRepNewPass.Text))
                    {
                        if (txtActualPass.Text.Equals(ArtistCache.Password) || ArtistCache.Password.Equals("")) { 
                        ArtistCache.Password = txtNewPass.Text;
                        AC.WriteInFile();
                        MessageBox.Show("contraseña Actualizada");
                        this.Height = 190;
                        txtNewPass.Text = "Nueva Contraseña";
                        txtRepNewPass.isPassword = false;
                        txtRepNewPass.Text = "Repetir Contraseña";
                        txtRepNewPass.isPassword = false;
                        txtActualPass.Text = "Contraseña Actual";
                        txtActualPass.isPassword = false;

                        }
                        else MessageBox.Show("La Contraseña actual no es correcta","Error de contraseña");
                    }
                    else MessageBox.Show("Las Contraseñas no Coinciden", "Error de contraseña");
                }
                else MessageBox.Show("Repita la Contraseña", "Error de contraseña");
            }
            else MessageBox.Show("La Contraseña debe tener al menos 5 caracteres", "Error de contraseña");
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Password.Equals("")) {
                MessageBox.Show("Cree primeramente una contraseña", "Crear contraseña");
            }
            else { 

          if (txtpass.Text.Equals(ArtistCache.Password))
            {
                ArtistCache.Bandera = true;
                this.Close();
            }
            else MessageBox.Show("Contraseña Incorrecta", "Error de contraseña");
        }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificarse_Load(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            ArtistCache.Bandera = false;
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
