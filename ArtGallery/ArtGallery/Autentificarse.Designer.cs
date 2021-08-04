namespace ArtGallery
{
    partial class Autentificarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificarse));
            this.allPanels = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActualPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtRepNewPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNewPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.allPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // allPanels
            // 
            this.allPanels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allPanels.Controls.Add(this.label4);
            this.allPanels.Controls.Add(this.label3);
            this.allPanels.Controls.Add(this.txtActualPass);
            this.allPanels.Controls.Add(this.pictureBox1);
            this.allPanels.Controls.Add(this.bunifuImageButton3);
            this.allPanels.Controls.Add(this.label2);
            this.allPanels.Controls.Add(this.bunifuImageButton2);
            this.allPanels.Controls.Add(this.txtRepNewPass);
            this.allPanels.Controls.Add(this.txtNewPass);
            this.allPanels.Controls.Add(this.label1);
            this.allPanels.Controls.Add(this.txtpass);
            this.allPanels.Controls.Add(this.bunifuImageButton1);
            this.allPanels.Controls.Add(this.shapeContainer1);
            this.allPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPanels.Location = new System.Drawing.Point(0, 0);
            this.allPanels.Name = "allPanels";
            this.allPanels.Size = new System.Drawing.Size(575, 190);
            this.allPanels.TabIndex = 0;
            this.allPanels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBar_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(366, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cerrar Sesión";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtActualPass
            // 
            this.txtActualPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActualPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActualPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActualPass.BorderThickness = 3;
            this.txtActualPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtActualPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActualPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActualPass.isPassword = false;
            this.txtActualPass.Location = new System.Drawing.Point(73, 360);
            this.txtActualPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtActualPass.MaxLength = 32767;
            this.txtActualPass.Name = "txtActualPass";
            this.txtActualPass.Size = new System.Drawing.Size(370, 44);
            this.txtActualPass.TabIndex = 18;
            this.txtActualPass.Text = "Contraseña Actual";
            this.txtActualPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActualPass.Enter += new System.EventHandler(this.TxtActualPass_Enter);
            this.txtActualPass.Leave += new System.EventHandler(this.TxtActualPass_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(11, 360);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(35, 44);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 9;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(211, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cambiar Contraseña";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(465, 360);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 44);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // txtRepNewPass
            // 
            this.txtRepNewPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepNewPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepNewPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepNewPass.BorderThickness = 3;
            this.txtRepNewPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRepNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepNewPass.isPassword = false;
            this.txtRepNewPass.Location = new System.Drawing.Point(73, 292);
            this.txtRepNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepNewPass.MaxLength = 32767;
            this.txtRepNewPass.Name = "txtRepNewPass";
            this.txtRepNewPass.Size = new System.Drawing.Size(370, 44);
            this.txtRepNewPass.TabIndex = 5;
            this.txtRepNewPass.Text = "Repetir Contraseña";
            this.txtRepNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepNewPass.Enter += new System.EventHandler(this.TxtRepNewPass_MouseDown);
            this.txtRepNewPass.Leave += new System.EventHandler(this.TxtRepNewPass_MouseEnter);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.BorderThickness = 3;
            this.txtNewPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.isPassword = false;
            this.txtNewPass.Location = new System.Drawing.Point(73, 224);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(370, 44);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.Text = "Nueva Contraseña";
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPass.Enter += new System.EventHandler(this.TxtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.TxtNewPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autentificarse";
            // 
            // txtpass
            // 
            this.txtpass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.BorderThickness = 3;
            this.txtpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.isPassword = false;
            this.txtpass.Location = new System.Drawing.Point(73, 85);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(370, 44);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Contraseña";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.Enter += new System.EventHandler(this.BunifuMetroTextbox1_Enter);
            this.txtpass.Leave += new System.EventHandler(this.Txtpass_Leave_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(465, 85);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(573, 188);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape1.X1 = 81;
            this.lineShape1.X2 = 437;
            this.lineShape1.Y1 = 195;
            this.lineShape1.Y2 = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(78, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sobre Nosotros";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Autentificarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(575, 190);
            this.Controls.Add(this.allPanels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autentificarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificarse";
            this.Load += new System.EventHandler(this.Autentificarse_Load);
            this.allPanels.ResumeLayout(false);
            this.allPanels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allPanels;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRepNewPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewPass;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtActualPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}