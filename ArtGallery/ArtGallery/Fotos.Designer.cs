namespace ArtGallery
{
    partial class Fotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fotos));
            this.FlowAll = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.txtAlbumName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblselect = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delFoto = new System.Windows.Forms.PictureBox();
            this.addFoto = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowAll
            // 
            this.FlowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowAll.AutoScroll = true;
            this.FlowAll.Location = new System.Drawing.Point(12, 65);
            this.FlowAll.Name = "FlowAll";
            this.FlowAll.Size = new System.Drawing.Size(775, 340);
            this.FlowAll.TabIndex = 0;
            this.FlowAll.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowAll_Paint);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.pictureBox3);
            this.TopPanel.Controls.Add(this.delFoto);
            this.TopPanel.Controls.Add(this.addFoto);
            this.TopPanel.Controls.Add(this.txtAlbumName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 59);
            this.TopPanel.TabIndex = 0;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.AutoSize = true;
            this.txtAlbumName.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumName.Location = new System.Drawing.Point(16, 9);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(108, 44);
            this.txtAlbumName.TabIndex = 27;
            this.txtAlbumName.Text = "Fotos";
            // 
            // lblselect
            // 
            this.lblselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(21, 425);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(118, 13);
            this.lblselect.TabIndex = 1;
            this.lblselect.Text = "Seleccionado: Ninguno";
            // 
            // star5
            // 
            this.star5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.star5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star5.Image = global::ArtGallery.Properties.Resources.NotFill;
            this.star5.Location = new System.Drawing.Point(716, 415);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(28, 28);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 6;
            this.star5.TabStop = false;
            this.star5.Tag = "NotFill";
            this.star5.Click += new System.EventHandler(this.Star5_Click);
            // 
            // star4
            // 
            this.star4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.star4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star4.Image = global::ArtGallery.Properties.Resources.NotFill;
            this.star4.Location = new System.Drawing.Point(688, 415);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(28, 28);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 5;
            this.star4.TabStop = false;
            this.star4.Tag = "NotFill";
            this.star4.Click += new System.EventHandler(this.Star4_Click);
            // 
            // star3
            // 
            this.star3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star3.Image = global::ArtGallery.Properties.Resources.NotFill;
            this.star3.Location = new System.Drawing.Point(660, 415);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(28, 28);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 4;
            this.star3.TabStop = false;
            this.star3.Tag = "NotFill";
            this.star3.Click += new System.EventHandler(this.Star3_Click);
            // 
            // star2
            // 
            this.star2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star2.Image = global::ArtGallery.Properties.Resources.NotFill;
            this.star2.Location = new System.Drawing.Point(632, 415);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(28, 28);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 3;
            this.star2.TabStop = false;
            this.star2.Tag = "NotFill";
            this.star2.Click += new System.EventHandler(this.Star2_Click);
            // 
            // star1
            // 
            this.star1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star1.Image = global::ArtGallery.Properties.Resources.NotFill;
            this.star1.Location = new System.Drawing.Point(604, 415);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(28, 28);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 2;
            this.star1.TabStop = false;
            this.star1.Tag = "NotFill";
            this.star1.Click += new System.EventHandler(this.Star1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(657, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // delFoto
            // 
            this.delFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delFoto.Image = ((System.Drawing.Image)(resources.GetObject("delFoto.Image")));
            this.delFoto.Location = new System.Drawing.Point(688, 18);
            this.delFoto.Name = "delFoto";
            this.delFoto.Size = new System.Drawing.Size(25, 25);
            this.delFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delFoto.TabIndex = 29;
            this.delFoto.TabStop = false;
            this.delFoto.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // addFoto
            // 
            this.addFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoto.Image = ((System.Drawing.Image)(resources.GetObject("addFoto.Image")));
            this.addFoto.Location = new System.Drawing.Point(719, 18);
            this.addFoto.Name = "addFoto";
            this.addFoto.Size = new System.Drawing.Size(25, 25);
            this.addFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addFoto.TabIndex = 28;
            this.addFoto.TabStop = false;
            this.addFoto.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.FlowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fotos";
            this.Text = "Fotos";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowAll;
        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel txtAlbumName;
        private System.Windows.Forms.PictureBox addFoto;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.PictureBox delFoto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star5;
    }
}