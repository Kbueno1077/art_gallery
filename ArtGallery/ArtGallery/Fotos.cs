using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class Fotos : Form
    {
        string albumName;
        string selectedPic = "";
        string selectPicName = "";

        ArtistCache Ac;
        public Fotos(string albumName)
        {
            this.albumName = albumName;
            Ac = new ArtistCache(albumName);
            InitializeComponent();
            txtAlbumName.Text = albumName;
            

        List<AlbumImage> albumImage = Ac.LoadImage(albumName);
            for (int i = 0; i < albumImage.Count; i++)
            {
                try
                {

                    //Panel pn = new Panel();
                    //pn.Size = new Size(230, 280);
                    //Bunifu.Framework.UI.BunifuRating rt = new Bunifu.Framework.UI.BunifuRating();
                    //rt.Size = new Size(180, 25);
                    //rt.ForeColor = Color.Silver;
                  
                    PictureBox Pic = new PictureBox();
                    Pic.Image = Image.FromFile(albumImage.ElementAt(i).PathImage);
                    Pic.ImageLocation = albumImage.ElementAt(i).PathImage;
                    Pic.Name = "Foto" + FlowAll.Controls.Count;
                    Pic.Size = new Size(220, 240);   
                    Pic.BorderStyle = BorderStyle.None;

                    Pic.Anchor = AnchorStyles.Left;
                    Pic.Anchor = AnchorStyles.Bottom;
                    Pic.Anchor = AnchorStyles.Right;
                    Pic.Anchor = AnchorStyles.Top;
                    Pic.SizeMode = PictureBoxSizeMode.Zoom;
                    Pic.MouseDoubleClick += DoubleClick;
                    Pic.MouseDown += FocusEnter;

                    //pn.Controls.Add(Pic);
                    //pn.Controls.Add(rt);
                    //rt.Location = new Point(20, 240);
                    

                    FlowAll.Controls.Add(Pic);
                 
                }
                catch (FileNotFoundException)
                {

                }
            }
        }


        private void FocusEnter(object sender, EventArgs e)
        {
            PictureBox Pic = sender as PictureBox;
            selectedPic = Pic.ImageLocation;
            selectPicName = Pic.Name;
            lblselect.Text = "Seleccionado: " + Path.GetFileName(selectedPic);
            int Rank = Ac.geRanking(selectedPic);


            if (Rank >= 0)
            {
                switch (Rank){
                    case 0: {
                            star1.Image = Properties.Resources.NotFill;
                            star1.Tag = "NotFill";
                            star2.Image = Properties.Resources.NotFill;
                            star2.Tag = "NotFill";
                            star3.Image = Properties.Resources.NotFill;
                            star3.Tag = "NotFill";
                            star4.Image = Properties.Resources.NotFill;
                            star4.Tag = "NotFill";
                            star5.Image = Properties.Resources.NotFill;
                            star5.Tag = "NotFill";
                        } break;
                    case 1: {
                            star1.Image = Properties.Resources.Fill222;
                            star1.Tag = "Fill";
                            star2.Image = Properties.Resources.NotFill;
                            star2.Tag = "NotFill";
                            star3.Image = Properties.Resources.NotFill;
                            star3.Tag = "NotFill";
                            star4.Image = Properties.Resources.NotFill;
                            star4.Tag = "NotFill";
                            star5.Image = Properties.Resources.NotFill;
                            star5.Tag = "NotFill";
                        }
                        break;
                    case 2: {
                            star1.Image = Properties.Resources.Fill222;
                            star1.Tag = "UpperFill";
                            star2.Image = Properties.Resources.Fill222;
                            star2.Tag = "Fill";
                            star3.Image = Properties.Resources.NotFill;
                            star3.Tag = "NotFill";
                            star4.Image = Properties.Resources.NotFill;
                            star4.Tag = "NotFill";
                            star5.Image = Properties.Resources.NotFill;
                            star5.Tag = "NotFill";
                        }
                        break;
                    case 3: {
                            star1.Image = Properties.Resources.Fill222;
                            star1.Tag = "UpperFill";
                            star2.Image = Properties.Resources.Fill222;
                            star2.Tag = "UpperFill";
                            star3.Image = Properties.Resources.Fill222;
                            star3.Tag = "Fill";
                            star4.Image = Properties.Resources.NotFill;
                            star4.Tag = "NotFill";
                            star5.Image = Properties.Resources.NotFill;
                            star5.Tag = "NotFill";
                        }
                        break;
                    case 4: {
                            star1.Image = Properties.Resources.Fill222;
                            star1.Tag = "UpperFill";
                            star2.Image = Properties.Resources.Fill222;
                            star2.Tag = "UpperFill";
                            star3.Image = Properties.Resources.Fill222;
                            star3.Tag = "UpperFill";
                            star4.Image = Properties.Resources.Fill222;
                            star4.Tag = "Fill";
                            star5.Image = Properties.Resources.NotFill;
                            star5.Tag = "NotFill";

                        }
                        break;
                    case 5:
                        {
                            star1.Image = Properties.Resources.Fill222;
                            star1.Tag = "UpperFill";
                            star2.Image = Properties.Resources.Fill222;
                            star2.Tag = "UpperFill";
                            star3.Image = Properties.Resources.Fill222;
                            star3.Tag = "UpperFill";
                            star4.Image = Properties.Resources.Fill222;
                            star4.Tag = "UpperFill";
                            star5.Image = Properties.Resources.Fill222;
                            star5.Tag = "Fill";
                        }
                        break;
                } 
            }
            else MessageBox.Show("No se pudo extraer el Rate de esta Imagen", "Error en el Rating");




        }

        private void DoubleClick(object sender, EventArgs e)
        {
            PictureBox Pic = sender as PictureBox;
            selectedPic = Pic.ImageLocation;
            _ = System.Diagnostics.Process.Start(selectedPic);
        }

        //insertar imagen
        private void PictureBox1_Click_1(object sender, EventArgs e)
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
                    string actualDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    actualDir += "\\Albums\\" + albumName + "\\";

                    string Origen = openFile.FileName;
                    string destino = actualDir;
                    try
                    {
                        File.Copy(Origen, Path.Combine(actualDir, Path.GetFileName(Origen)), false);
                        ArtistCache.PathImage = Path.Combine(actualDir, Path.GetFileName(Origen));

                        PictureBox Pic = new PictureBox();
                        Pic.ImageLocation = Path.Combine(actualDir, Path.GetFileName(Origen));
                        Pic.Name = "Foto" + FlowAll.Controls.Count;
                        Pic.Image = Image.FromFile(Path.Combine(actualDir, Path.GetFileName(Origen)));
                        Pic.Size = new Size(220, 240);

                        Pic.Anchor = AnchorStyles.Left;
                        Pic.Anchor = AnchorStyles.Bottom;
                        Pic.Anchor = AnchorStyles.Right;
                        Pic.Anchor = AnchorStyles.Top;

                        Pic.SizeMode = PictureBoxSizeMode.Zoom;
                        Pic.MouseDoubleClick += DoubleClick;
                        Pic.MouseDown += FocusEnter;
                        FlowAll.Controls.Add(Pic);
                        AlbumImage image = new AlbumImage(albumName, Path.Combine(actualDir, Path.GetFileName(Origen)));
                        Ac.AddImage(image);
                    }

                    catch (IOException) { MessageBox.Show("Esta Imagen ya ha sido incluida, \n procure que tenga al menos nombres diferentes", "Imagen ya Existente"); }
                }
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        //borrar imagen
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                if (!selectedPic.Equals(""))
                {
                    try
                    {
                        Control[] PicControl = FlowAll.Controls.Find(selectPicName, false);
                        PictureBox Pic = PicControl[0] as PictureBox;
                        FlowAll.Controls.RemoveByKey(selectPicName);
                        Pic.Dispose();
                        Ac.RemoveImage(selectedPic);

                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();

                        File.Delete(selectedPic);
                    }
                    catch (Exception ex) { MessageBox.Show("No se pudo borrar, intente de nuevo \n " + ex.Message, "Erro Esperado"); }


                }
                else MessageBox.Show("Seleccione una imagen ha eliminar, la imagen seleccionada se mostrará en la parte inferior de la ventaa", "Imagen no seleccionada");
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FlowAll.Visible = false;
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            FlowAll.Visible = true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            string actualDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            actualDir += "\\Albums\\" + albumName + "\\";
            string newPath = "";
            using (var fbd = new FolderBrowserDialog())
            {

                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    newPath = fbd.SelectedPath + "\\"+albumName+"\\";
                    Directory.CreateDirectory(newPath);
                    foreach (string path in Directory.GetFiles(actualDir, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(path, path.Replace(actualDir, newPath), true);
                     }
                    MessageBox.Show("Album copiado exitosamente", "Album Copiado");
                }
            }
        }

        private void FlowAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Star1_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera ==true) { 
            string Fill = star1.Tag as string;
            int Rank;
            if (Fill.Equals("NotFill"))
            {
                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "Fill";
                Rank = 1;
            }
            else if (Fill.Equals("UpperFill"))
            {
                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "Fill";
                star2.Image = Properties.Resources.NotFill;
                star2.Tag = "NotFill";
                star3.Image = Properties.Resources.NotFill;
                star3.Tag = "NotFill";
                star4.Image = Properties.Resources.NotFill;
                star4.Tag = "NotFill";
                star5.Image = Properties.Resources.NotFill;
                star5.Tag = "NotFill";
                Rank = 1;

            }
            else {
                star1.Image = Properties.Resources.NotFill;
                star1.Tag = "NotFill";
                Rank = 0;
            }
            Ac.EditRankig(Rank, selectedPic);

            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void Star2_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                int Rank;
            string Fill = star2.Tag as string;
            if (Fill.Equals("NotFill"))
            {

                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "UpperFill";
                star2.Image = Properties.Resources.Fill222;
                star2.Tag = "Fill";
                Rank = 2;


            }
            else if (Fill.Equals("UpperFill"))
            {


                star2.Image = Properties.Resources.Fill222;
                star2.Tag = "Fill";
                star3.Image = Properties.Resources.NotFill;
                star3.Tag = "NotFill";
                star4.Image = Properties.Resources.NotFill;
                star4.Tag = "NotFill";
                star5.Image = Properties.Resources.NotFill;
                star5.Tag = "NotFill";
                Rank = 2;
            }
            else {
                star2.Image = Properties.Resources.NotFill;
                star2.Tag = "NotFill";
                Rank = 1;
            }
            Ac.EditRankig(Rank, selectedPic);
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void Star3_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                int Rank;
            string Fill = star3.Tag as string;
            if (Fill.Equals("NotFill"))
            {

                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "UpperFill";
                star2.Image = Properties.Resources.Fill222;
                star2.Tag = "UpperFill";
                star3.Image = Properties.Resources.Fill222;
                star3.Tag = "Fill";
                Rank = 3;



            }
            else if (Fill.Equals("UpperFill"))
            {

                star3.Image = Properties.Resources.Fill222;
                star3.Tag = "Fill";
                star4.Image = Properties.Resources.NotFill;
                star4.Tag = "NotFill";
                star5.Image = Properties.Resources.NotFill;
                star5.Tag = "NotFill";
                Rank = 3;

            }
            else {
                star3.Image = Properties.Resources.NotFill;
                star3.Tag = "NotFill";
                Rank = 2;
            }
            Ac.EditRankig(Rank, selectedPic);
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void Star4_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                int Rank;
            string Fill = star4.Tag as string;
            if (Fill.Equals("NotFill"))
            {

                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "UpperFill";
                star2.Image = Properties.Resources.Fill222;
                star2.Tag = "UpperFill";
                star3.Image = Properties.Resources.Fill222;
                star3.Tag = "UpperFill";
                star4.Image = Properties.Resources.Fill222;
                star4.Tag = "Fill";
                Rank = 4;



            }
            else if(Fill.Equals("UpperFill"))
            {
                star4.Image = Properties.Resources.Fill222;
                star4.Tag = "Fill";
                star5.Image = Properties.Resources.NotFill;
                star5.Tag = "NotFill";
                Rank = 4;

            }
            else
            {
                star4.Image = Properties.Resources.NotFill;
                star4.Tag = "NotFill";
                Rank = 3;
            }
            Ac.EditRankig(Rank, selectedPic);
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        private void Star5_Click(object sender, EventArgs e)
        {
            if (ArtistCache.Bandera == true)
            {
                int Rank;
            string Fill = star5.Tag as string;
            if (Fill.Equals("NotFill"))
            {

                star1.Image = Properties.Resources.Fill222;
                star1.Tag = "UpperFill";
                star2.Image = Properties.Resources.Fill222;
                star2.Tag = "UpperFill";
                star3.Image = Properties.Resources.Fill222;
                star3.Tag = "UpperFill";
                star4.Image = Properties.Resources.Fill222;
                star4.Tag = "UpperFill";
                star5.Image = Properties.Resources.Fill222;
                star5.Tag = "UpperFill";
                Rank = 5;

            }
            else 
            {

                star5.Image = Properties.Resources.NotFill;
                star5.Tag = "NotFill";
                Rank = 4;
            }
            Ac.EditRankig(Rank, selectedPic);
            }
            else MessageBox.Show("Debe autentificarse para realizar esta acción", "Autentificación requerida");
        }

        


    }
}
