using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtGallery;

namespace ArtGallery
{
    public partial class Gallery : Form
    {

        ArtistCache Ac = new ArtistCache("Gallery");
        string selectedAlbum = "";
        string selectedAlbumName = "";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg,
            int wparam, int lparam);


        //Top Bar and WindowsMove and Resize
        #region
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                 )
                Application.Exit();

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        int lx, ly;
        int sw, sh;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.allPanels.Region = region;
            this.Invalidate();
        }

        //--------------------------------------COLOR Y GRIP DEL RECTAGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush;
           
                blueBrush = new SolidBrush(Color.FromArgb(249, 249, 249));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
           // ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void TopBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void Gallery_Load(object sender, EventArgs e)
        {
            mostrarLogo();
            try
            {
                lblArtist.Text = ArtistCache.Apodo;
            }
            catch (Exception) { }
            
            ArtistCache.Bandera = false;

            try
            {
                ActualPicture.Image = Image.FromFile(ArtistCache.PathImage);
            }
            catch (Exception) { }

            //cargar los botones del sideBar que representan los albums
            List<AlbumButton> albumButton = Ac.LoadButton();
            for (int i = 0; i < albumButton.Count; i++)
            {
                try
                {
                    Bunifu.Framework.UI.BunifuFlatButton Flat = new Bunifu.Framework.UI.BunifuFlatButton();
                    Flat.Activecolor = Color.Transparent;
                    Flat.Normalcolor = Color.Transparent;
                    Flat.BackColor = Color.Transparent;
                    Flat.OnHovercolor = Color.Transparent;
                    Flat.OnHoverTextColor = Color.Black;
                    Flat.IconZoom = 40;
                    Flat.DisabledColor = Color.Gray;
                    Flat.Iconimage = Properties.Resources.photo;
                    Flat.Iconcolor = Color.Transparent;
                    Flat.TextAlign = ContentAlignment.MiddleLeft;
                    Flat.BackgroundImageLayout = ImageLayout.Stretch;
                    Flat.Textcolor = Color.FromArgb(51, 52, 52);
                    Flat.Size = new Size(222, 32);
                    Flat.Name = "Button" + flowButton.Controls.Count;
                    Flat.Text = albumButton.ElementAt(i).AlbumName;
                    Flat.MouseDown += OpenFotos;
                    flowButton.Controls.Add(Flat);
                    
                }
                catch (FileNotFoundException)
                { }
            }


        }


        public Gallery()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(object FormHijo)
        {
            if (this.workArea.Controls.Count > 0)
                this.workArea.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.workArea.Controls.Add(fh);
            this.workArea.Tag = fh;
            fh.Opacity = 1.00;
            fh.Show();
        }

         public void OpenFotos(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton Flat = sender as Bunifu.Framework.UI.BunifuFlatButton;
            selectedAlbum = Flat.Text;
            selectedAlbumName = Flat.Name;
            Flat.Focus();
            OpenFormInPanel(new Fotos(Flat.Text));
        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            Autentificarse ai = new Autentificarse();
            ai.FormClosed += AutentificarseFormClosed;
            ai.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ArtistInfo ai = new ArtistInfo();
            ai.FormClosed += ChangeStuff;
            ai.ShowDialog();
        }

      
        private void AutentificarseFormClosed(object sender, FormClosedEventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                verified.Visible = true;
                button1.Text = "Autentificado";
               
            }
            else
            {
                verified.Visible = false;
                button1.Text = "Autentificarse";
                
            }
            mostrarLogo();
        }


        //Crear  nuevo Album
        private void AddFoto_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (!txtAlbum.Text.Equals("Añadir Album") && !txtAlbum.Text.Equals(""))
                {
                    string actualDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    actualDir += "\\Albums\\" + txtAlbum.Text.Trim() + "\\";

                    txtAlbum.Text = txtAlbum.Text.Trim();

                    if (!Directory.Exists(actualDir))
                    {
                        Bunifu.Framework.UI.BunifuFlatButton Flat = new Bunifu.Framework.UI.BunifuFlatButton();
                        Flat.Activecolor = Color.Transparent;
                        Flat.Normalcolor = Color.Transparent;
                        Flat.BackColor = Color.Transparent;
                        Flat.OnHovercolor = Color.Transparent;
                        Flat.OnHoverTextColor = Color.Black;
                        Flat.IconZoom = 40;
                        Flat.DisabledColor = Color.Gray;
                        Flat.Iconimage = Properties.Resources.photo;
                        Flat.Iconcolor = Color.Transparent;
                        Flat.TextAlign = ContentAlignment.MiddleLeft;
                        Flat.BackgroundImageLayout = ImageLayout.Stretch;
                        Flat.Textcolor = Color.FromArgb(51, 52, 52);
                        Flat.Size = new Size(222, 32);
                        Flat.Name = "Button" + flowButton.Controls.Count;
                        Flat.Text = txtAlbum.Text;
                        Directory.CreateDirectory(actualDir);
                        //Events
                        Flat.MouseDown += OpenFotos;

                        Ac.AddButton(new AlbumButton(txtAlbum.Text));
                        Ac.WriteInFileButton();
                        Flat.Focus();
                        flowButton.Controls.Add(Flat);
                    }

                    else MessageBox.Show("Este Album ya Existe", "Album Ya Existente");
                }
                else MessageBox.Show("Ingrese un nombre a su album", "Nombre de Album");

                txtAlbum.Text = "";
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void TxtAlbum_Enter(object sender, EventArgs e)
        {
            if (txtAlbum.Text == "Añadir Album")
            {
                txtAlbum.Text = "";
              
            }
        }

        private void TxtAlbum_Leave(object sender, EventArgs e)
        {
            if (txtAlbum.Text == "")
            {
                txtAlbum.Text = "Añadir Album";
            }

        }

        //eliminar Album
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (!selectedAlbum.Equals(""))
                {
                    try
                    {
                        string actualDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                        actualDir += "\\Albums\\" + selectedAlbum.Trim() + "\\";

                        selectedAlbum = selectedAlbum.Trim();

                        Control[] FlatControl = flowButton.Controls.Find(selectedAlbumName, false);
                        Bunifu.Framework.UI.BunifuFlatButton Flat = FlatControl[0] as Bunifu.Framework.UI.BunifuFlatButton;
                        flowButton.Controls.RemoveByKey(selectedAlbumName);
                        Flat.Dispose();
                        Ac.RemoveButton(selectedAlbum);

                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        mostrarLogo();

                        foreach (var item in System.IO.Directory.GetFiles(actualDir))
                        {
                            File.Delete(item);
                        }

                        Directory.Delete(actualDir);
                        mostrarLogo();

                    }
                    catch (Exception ex) { MessageBox.Show("Error Esperado, Algo Paso \n" + ex.Message); }
                }
                else MessageBox.Show("Seleccione un Album para eliminar", "Album no seleccionado");
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //private void BunifuButton1_Click(object sender, EventArgs e)
        //{
            
        //        new Thread(() =>
        //        {
        //            SplashScreen Sp = new SplashScreen();
        //            Sp.ShowDialog();
        //        }).Start();
            

        //}

        private void ChangeStuff(object sender, FormClosedEventArgs e)
        {
            lblArtist.Text = ArtistCache.Apodo;
            try
            {
                ActualPicture.Image = Image.FromFile(ArtistCache.PathImage);
            }
            catch (Exception) { }

        }

        private void mostrarLogo() {
            selectedAlbum = "";
            selectedAlbumName = "";
            OpenFormInPanel(new Logo());
          
        }








    }
}
