namespace HMIMaterialSkin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msTema = new MaterialSkin.Controls.MaterialSwitch();
            this.gbLEDs = new System.Windows.Forms.GroupBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.pbAmarillo = new System.Windows.Forms.PictureBox();
            this.pbRojo = new System.Windows.Forms.PictureBox();
            this.chkVerde = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkAmarillo = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkRed = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConectar = new MaterialSkin.Controls.MaterialButton();
            this.btnDesc = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBaud = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbPuerto = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbLEDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTema
            // 
            this.msTema.AutoSize = true;
            this.msTema.BackColor = System.Drawing.Color.BlueViolet;
            this.msTema.Depth = 0;
            this.msTema.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTema.Location = new System.Drawing.Point(4, 76);
            this.msTema.Margin = new System.Windows.Forms.Padding(0);
            this.msTema.MouseLocation = new System.Drawing.Point(-1, -1);
            this.msTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.msTema.Name = "msTema";
            this.msTema.Ripple = true;
            this.msTema.Size = new System.Drawing.Size(95, 37);
            this.msTema.TabIndex = 0;
            this.msTema.Text = "Claro";
            this.msTema.UseVisualStyleBackColor = false;
            this.msTema.CheckedChanged += new System.EventHandler(this.msTema_CheckedChanged);
            // 
            // gbLEDs
            // 
            this.gbLEDs.Controls.Add(this.pbVerde);
            this.gbLEDs.Controls.Add(this.pbAmarillo);
            this.gbLEDs.Controls.Add(this.pbRojo);
            this.gbLEDs.Controls.Add(this.chkVerde);
            this.gbLEDs.Controls.Add(this.chkAmarillo);
            this.gbLEDs.Controls.Add(this.chkRed);
            this.gbLEDs.Location = new System.Drawing.Point(17, 74);
            this.gbLEDs.Name = "gbLEDs";
            this.gbLEDs.Size = new System.Drawing.Size(691, 144);
            this.gbLEDs.TabIndex = 2;
            this.gbLEDs.TabStop = false;
            this.gbLEDs.Text = "Control LEDS";
            // 
            // pbVerde
            // 
            this.pbVerde.Image = global::HMIMaterialSkin.Properties.Resources.VerdeOff;
            this.pbVerde.Location = new System.Drawing.Point(482, 28);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(86, 78);
            this.pbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVerde.TabIndex = 8;
            this.pbVerde.TabStop = false;
            // 
            // pbAmarillo
            // 
            this.pbAmarillo.Image = global::HMIMaterialSkin.Properties.Resources.AmarilloOff;
            this.pbAmarillo.Location = new System.Drawing.Point(311, 28);
            this.pbAmarillo.Name = "pbAmarillo";
            this.pbAmarillo.Size = new System.Drawing.Size(86, 78);
            this.pbAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAmarillo.TabIndex = 7;
            this.pbAmarillo.TabStop = false;
            // 
            // pbRojo
            // 
            this.pbRojo.Image = global::HMIMaterialSkin.Properties.Resources.RojoOff;
            this.pbRojo.Location = new System.Drawing.Point(130, 28);
            this.pbRojo.Name = "pbRojo";
            this.pbRojo.Size = new System.Drawing.Size(86, 78);
            this.pbRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRojo.TabIndex = 6;
            this.pbRojo.TabStop = false;
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Depth = 0;
            this.chkVerde.Location = new System.Drawing.Point(494, 103);
            this.chkVerde.Margin = new System.Windows.Forms.Padding(0);
            this.chkVerde.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkVerde.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.ReadOnly = false;
            this.chkVerde.Ripple = true;
            this.chkVerde.Size = new System.Drawing.Size(55, 37);
            this.chkVerde.TabIndex = 5;
            this.chkVerde.Text = "On";
            this.chkVerde.UseVisualStyleBackColor = true;
            this.chkVerde.CheckedChanged += new System.EventHandler(this.chkVerde_CheckedChanged);
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Depth = 0;
            this.chkAmarillo.Location = new System.Drawing.Point(323, 103);
            this.chkAmarillo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAmarillo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAmarillo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.ReadOnly = false;
            this.chkAmarillo.Ripple = true;
            this.chkAmarillo.Size = new System.Drawing.Size(55, 37);
            this.chkAmarillo.TabIndex = 4;
            this.chkAmarillo.Text = "On";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            this.chkAmarillo.CheckedChanged += new System.EventHandler(this.chkAmarillo_CheckedChanged);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Depth = 0;
            this.chkRed.Location = new System.Drawing.Point(147, 102);
            this.chkRed.Margin = new System.Windows.Forms.Padding(0);
            this.chkRed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRed.Name = "chkRed";
            this.chkRed.ReadOnly = false;
            this.chkRed.Ripple = true;
            this.chkRed.Size = new System.Drawing.Size(55, 37);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "On";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConectar);
            this.groupBox3.Controls.Add(this.btnDesc);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.cmbBaud);
            this.groupBox3.Controls.Add(this.cmbPuerto);
            this.groupBox3.Location = new System.Drawing.Point(17, 225);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(575, 150);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conexión Serial";
            // 
            // btnConectar
            // 
            this.btnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConectar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConectar.Depth = 0;
            this.btnConectar.HighEmphasis = true;
            this.btnConectar.Icon = null;
            this.btnConectar.Location = new System.Drawing.Point(442, 42);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConectar.Size = new System.Drawing.Size(126, 36);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "        Conectar        ";
            this.btnConectar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConectar.UseAccentColor = false;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDesc.Depth = 0;
            this.btnDesc.HighEmphasis = true;
            this.btnDesc.Icon = null;
            this.btnDesc.Location = new System.Drawing.Point(442, 89);
            this.btnDesc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDesc.Size = new System.Drawing.Size(125, 36);
            this.btnDesc.TabIndex = 4;
            this.btnDesc.Text = "Desconectar";
            this.btnDesc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDesc.UseAccentColor = false;
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Baud Rate:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Puerto:";
            // 
            // cmbBaud
            // 
            this.cmbBaud.AutoResize = false;
            this.cmbBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBaud.Depth = 0;
            this.cmbBaud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBaud.DropDownHeight = 174;
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.DropDownWidth = 121;
            this.cmbBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.IntegralHeight = false;
            this.cmbBaud.ItemHeight = 43;
            this.cmbBaud.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(130, 84);
            this.cmbBaud.MaxDropDownItems = 4;
            this.cmbBaud.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(295, 49);
            this.cmbBaud.StartIndex = 0;
            this.cmbBaud.TabIndex = 1;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.AutoResize = false;
            this.cmbPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPuerto.Depth = 0;
            this.cmbPuerto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPuerto.DropDownHeight = 174;
            this.cmbPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuerto.DropDownWidth = 121;
            this.cmbPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPuerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.IntegralHeight = false;
            this.cmbPuerto.ItemHeight = 43;
            this.cmbPuerto.Location = new System.Drawing.Point(130, 29);
            this.cmbPuerto.MaxDropDownItems = 4;
            this.cmbPuerto.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(295, 49);
            this.cmbPuerto.StartIndex = 0;
            this.cmbPuerto.TabIndex = 0;
            this.cmbPuerto.DropDown += new System.EventHandler(this.materialComboBox1_DropDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.msTema);
            this.groupBox4.Location = new System.Drawing.Point(599, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tema";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 396);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbLEDs);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMI";
            this.gbLEDs.ResumeLayout(false);
            this.gbLEDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch msTema;
        private System.Windows.Forms.GroupBox gbLEDs;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialCheckbox chkVerde;
        private MaterialSkin.Controls.MaterialCheckbox chkAmarillo;
        private MaterialSkin.Controls.MaterialCheckbox chkRed;
        private MaterialSkin.Controls.MaterialComboBox cmbBaud;
        private MaterialSkin.Controls.MaterialComboBox cmbPuerto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnConectar;
        private MaterialSkin.Controls.MaterialButton btnDesc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbRojo;
        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.PictureBox pbAmarillo;
    }
}

