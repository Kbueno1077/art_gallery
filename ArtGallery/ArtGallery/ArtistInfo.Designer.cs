namespace ArtGallery
{
    partial class ArtistInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistInfo));
            this.allPanels = new System.Windows.Forms.Panel();
            this.datepicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtApodo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPicture = new ArtGallery.OvalPictureBox();
            this.allPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // allPanels
            // 
            this.allPanels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allPanels.Controls.Add(this.datepicker);
            this.allPanels.Controls.Add(this.txtApodo);
            this.allPanels.Controls.Add(this.pictureBox5);
            this.allPanels.Controls.Add(this.pictureBox4);
            this.allPanels.Controls.Add(this.pictureBox3);
            this.allPanels.Controls.Add(this.pictureBox2);
            this.allPanels.Controls.Add(this.pictureBox1);
            this.allPanels.Controls.Add(this.txtEmail);
            this.allPanels.Controls.Add(this.txtName);
            this.allPanels.Controls.Add(this.txtPicture);
            this.allPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPanels.Location = new System.Drawing.Point(0, 0);
            this.allPanels.Name = "allPanels";
            this.allPanels.Size = new System.Drawing.Size(492, 234);
            this.allPanels.TabIndex = 0;
            this.allPanels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBar_MouseDown);
            // 
            // datepicker
            // 
            this.datepicker.BackColor = System.Drawing.Color.Transparent;
            this.datepicker.BorderRadius = 1;
            this.datepicker.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.datepicker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datepicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.datepicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datepicker.DisabledColor = System.Drawing.Color.DimGray;
            this.datepicker.DisplayWeekNumbers = false;
            this.datepicker.DPHeight = 0;
            this.datepicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datepicker.Enabled = false;
            this.datepicker.FillDatePicker = false;
            this.datepicker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datepicker.Icon = ((System.Drawing.Image)(resources.GetObject("datepicker.Icon")));
            this.datepicker.IconColor = System.Drawing.Color.Black;
            this.datepicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datepicker.Location = new System.Drawing.Point(201, 161);
            this.datepicker.MinimumSize = new System.Drawing.Size(217, 32);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(217, 32);
            this.datepicker.TabIndex = 23;
            // 
            // txtApodo
            // 
            this.txtApodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApodo.AutoSize = true;
            this.txtApodo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApodo.Enabled = false;
            this.txtApodo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApodo.HintForeColor = System.Drawing.Color.Empty;
            this.txtApodo.HintText = "";
            this.txtApodo.isPassword = false;
            this.txtApodo.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtApodo.LineIdleColor = System.Drawing.Color.Transparent;
            this.txtApodo.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txtApodo.LineThickness = 3;
            this.txtApodo.Location = new System.Drawing.Point(37, 176);
            this.txtApodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtApodo.MaxLength = 32767;
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(122, 29);
            this.txtApodo.TabIndex = 22;
            this.txtApodo.Text = "Nombre Artistico";
            this.txtApodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApodo.OnValueChanged += new System.EventHandler(this.TxtApodo_OnValueChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(427, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(427, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(201, 107);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 33);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(201, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 33);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "Nombre";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPicture
            // 
            this.txtPicture.BackColor = System.Drawing.Color.Transparent;
            this.txtPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPicture.Image = global::ArtGallery.Properties.Resources.user_circle_o;
            this.txtPicture.Location = new System.Drawing.Point(34, 37);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(120, 120);
            this.txtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtPicture.TabIndex = 12;
            this.txtPicture.TabStop = false;
            this.txtPicture.Click += new System.EventHandler(this.TxtPicture_Click);
            this.txtPicture.DoubleClick += new System.EventHandler(this.TxtPicture_DoubleClick);
            // 
            // ArtistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(492, 234);
            this.Controls.Add(this.allPanels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArtistInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WorkPlace";
            this.allPanels.ResumeLayout(false);
            this.allPanels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allPanels;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private OvalPictureBox txtPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApodo;
        private Bunifu.UI.WinForms.BunifuDatePicker datepicker;
    }
}