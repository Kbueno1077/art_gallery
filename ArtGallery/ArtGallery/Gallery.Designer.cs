namespace ArtGallery
{
    partial class Gallery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gallery));
            this.allPanels = new System.Windows.Forms.Panel();
            this.workArea = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblArtist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.verified = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAlbum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addFoto = new System.Windows.Forms.PictureBox();
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.ActualPicture = new ArtGallery.OvalPictureBox();
            this.Libreria = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.allPanels.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allPanels
            // 
            this.allPanels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(224)))));
            this.allPanels.Controls.Add(this.workArea);
            this.allPanels.Controls.Add(this.TopBar);
            this.allPanels.Controls.Add(this.sideBar);
            this.allPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPanels.Location = new System.Drawing.Point(0, 0);
            this.allPanels.Name = "allPanels";
            this.allPanels.Size = new System.Drawing.Size(1000, 550);
            this.allPanels.TabIndex = 0;
            // 
            // workArea
            // 
            this.workArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea.Location = new System.Drawing.Point(250, 47);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(750, 503);
            this.workArea.TabIndex = 1;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TopBar.Controls.Add(this.pictureBox6);
            this.TopBar.Controls.Add(this.btnRestaurar);
            this.TopBar.Controls.Add(this.btnMaximizar);
            this.TopBar.Controls.Add(this.pictureBox3);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Controls.Add(this.button1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(250, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(750, 47);
            this.TopBar.TabIndex = 2;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(658, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(682, 10);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(18, 18);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 16;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(682, 10);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(18, 18);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 15;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(706, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "The Gallery";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(462, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Autentificarse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(224)))));
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideBar.Controls.Add(this.lblArtist);
            this.sideBar.Controls.Add(this.verified);
            this.sideBar.Controls.Add(this.pictureBox2);
            this.sideBar.Controls.Add(this.txtAlbum);
            this.sideBar.Controls.Add(this.addFoto);
            this.sideBar.Controls.Add(this.flowButton);
            this.sideBar.Controls.Add(this.ActualPicture);
            this.sideBar.Controls.Add(this.Libreria);
            this.sideBar.Controls.Add(this.pictureBox1);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(204)))));
            this.sideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(204)))));
            this.sideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.sideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Quality = 10;
            this.sideBar.Size = new System.Drawing.Size(250, 550);
            this.sideBar.TabIndex = 0;
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblArtist.Location = new System.Drawing.Point(77, 99);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(103, 64);
            this.lblArtist.TabIndex = 32;
            this.lblArtist.Text = "Bienvenido";
            // 
            // verified
            // 
            this.verified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verified.BackColor = System.Drawing.Color.Transparent;
            this.verified.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.verified.Image = ((System.Drawing.Image)(resources.GetObject("verified.Image")));
            this.verified.Location = new System.Drawing.Point(225, 17);
            this.verified.Name = "verified";
            this.verified.Size = new System.Drawing.Size(17, 14);
            this.verified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verified.TabIndex = 18;
            this.verified.TabStop = false;
            this.verified.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // txtAlbum
            // 
            this.txtAlbum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlbum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlbum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlbum.BorderThickness = 3;
            this.txtAlbum.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAlbum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlbum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlbum.isPassword = false;
            this.txtAlbum.Location = new System.Drawing.Point(4, 206);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlbum.MaxLength = 32767;
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(239, 33);
            this.txtAlbum.TabIndex = 30;
            this.txtAlbum.Text = "Añadir Album";
            this.txtAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAlbum.Enter += new System.EventHandler(this.TxtAlbum_Enter);
            this.txtAlbum.Leave += new System.EventHandler(this.TxtAlbum_Leave);
            // 
            // addFoto
            // 
            this.addFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoto.Image = ((System.Drawing.Image)(resources.GetObject("addFoto.Image")));
            this.addFoto.Location = new System.Drawing.Point(225, 182);
            this.addFoto.Name = "addFoto";
            this.addFoto.Size = new System.Drawing.Size(18, 18);
            this.addFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addFoto.TabIndex = 29;
            this.addFoto.TabStop = false;
            this.addFoto.Click += new System.EventHandler(this.AddFoto_Click);
            // 
            // flowButton
            // 
            this.flowButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowButton.AutoScroll = true;
            this.flowButton.Location = new System.Drawing.Point(3, 246);
            this.flowButton.Name = "flowButton";
            this.flowButton.Size = new System.Drawing.Size(241, 273);
            this.flowButton.TabIndex = 12;
            // 
            // ActualPicture
            // 
            this.ActualPicture.BackColor = System.Drawing.Color.Transparent;
            this.ActualPicture.Image = global::ArtGallery.Properties.Resources.user_circle_o;
            this.ActualPicture.Location = new System.Drawing.Point(85, 24);
            this.ActualPicture.Name = "ActualPicture";
            this.ActualPicture.Size = new System.Drawing.Size(72, 72);
            this.ActualPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActualPicture.TabIndex = 10;
            this.ActualPicture.TabStop = false;
            // 
            // Libreria
            // 
            this.Libreria.AutoSize = true;
            this.Libreria.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libreria.Location = new System.Drawing.Point(8, 182);
            this.Libreria.Name = "Libreria";
            this.Libreria.Size = new System.Drawing.Size(60, 18);
            this.Libreria.TabIndex = 4;
            this.Libreria.Text = "Libreria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.allPanels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Gallery";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Gallery_Load);
            this.allPanels.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allPanels;
        private System.Windows.Forms.Panel workArea;
        private Bunifu.Framework.UI.BunifuGradientPanel sideBar;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel Libreria;
        private OvalPictureBox ActualPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowButton;
        private System.Windows.Forms.PictureBox addFoto;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAlbum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox verified;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArtist;
    }
}

