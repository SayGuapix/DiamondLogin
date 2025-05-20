namespace DIAMOND
{
    partial class Diamond
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
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ptbLineas3 = new System.Windows.Forms.PictureBox();
            this.ptbLineas2 = new System.Windows.Forms.PictureBox();
            this.ptbLineas1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblhasIngresado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbSalir
            // 
            this.ptbSalir.Image = global::DIAMOND.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(989, 13);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 32);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 10;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            this.ptbSalir.MouseLeave += new System.EventHandler(this.ptbSalir_MouseLeave);
            this.ptbSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbSalir_MouseMove);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lblSalir.ForeColor = System.Drawing.Color.Silver;
            this.lblSalir.Location = new System.Drawing.Point(937, 17);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(49, 24);
            this.lblSalir.TabIndex = 35;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Visible = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::DIAMOND.Properties.Resources.Logo;
            this.ptbLogo.Location = new System.Drawing.Point(123, 98);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(163, 162);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 37;
            this.ptbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Snow;
            this.lblLogo.Font = new System.Drawing.Font("Constantia", 25F);
            this.lblLogo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLogo.Location = new System.Drawing.Point(111, 163);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(188, 41);
            this.lblLogo.TabIndex = 39;
            this.lblLogo.Text = "DIAMOND";
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.Color.Snow;
            this.pnlAzul.Controls.Add(this.lblLogo);
            this.pnlAzul.Controls.Add(this.ptbLogo);
            this.pnlAzul.Controls.Add(this.btnCerrar);
            this.pnlAzul.Location = new System.Drawing.Point(-1, -1);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(408, 603);
            this.pnlAzul.TabIndex = 36;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(408, 96);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "CERRAR SESION";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ptbLineas3
            // 
            this.ptbLineas3.Image = global::DIAMOND.Properties.Resources.Linea;
            this.ptbLineas3.Location = new System.Drawing.Point(481, 275);
            this.ptbLineas3.Margin = new System.Windows.Forms.Padding(2);
            this.ptbLineas3.Name = "ptbLineas3";
            this.ptbLineas3.Size = new System.Drawing.Size(490, 32);
            this.ptbLineas3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLineas3.TabIndex = 52;
            this.ptbLineas3.TabStop = false;
            // 
            // ptbLineas2
            // 
            this.ptbLineas2.Image = global::DIAMOND.Properties.Resources.Linea;
            this.ptbLineas2.Location = new System.Drawing.Point(481, 182);
            this.ptbLineas2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbLineas2.Name = "ptbLineas2";
            this.ptbLineas2.Size = new System.Drawing.Size(490, 32);
            this.ptbLineas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLineas2.TabIndex = 49;
            this.ptbLineas2.TabStop = false;
            // 
            // ptbLineas1
            // 
            this.ptbLineas1.Image = global::DIAMOND.Properties.Resources.Linea;
            this.ptbLineas1.Location = new System.Drawing.Point(481, 89);
            this.ptbLineas1.Margin = new System.Windows.Forms.Padding(2);
            this.ptbLineas1.Name = "ptbLineas1";
            this.ptbLineas1.Size = new System.Drawing.Size(490, 32);
            this.ptbLineas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLineas1.TabIndex = 44;
            this.ptbLineas1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(489, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 38);
            this.lblUsuario.TabIndex = 56;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(491, 142);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(102, 38);
            this.lblCorreo.TabIndex = 57;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(491, 235);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(87, 38);
            this.lblCurso.TabIndex = 58;
            this.lblCurso.Text = "Curso";
            // 
            // lblhasIngresado
            // 
            this.lblhasIngresado.AutoSize = true;
            this.lblhasIngresado.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblhasIngresado.ForeColor = System.Drawing.Color.Cyan;
            this.lblhasIngresado.Location = new System.Drawing.Point(500, 417);
            this.lblhasIngresado.Name = "lblhasIngresado";
            this.lblhasIngresado.Size = new System.Drawing.Size(454, 79);
            this.lblhasIngresado.TabIndex = 59;
            this.lblhasIngresado.Text = "Has ingresado!";
            // 
            // Diamond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1034, 601);
            this.Controls.Add(this.lblhasIngresado);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptbLineas3);
            this.Controls.Add(this.ptbLineas2);
            this.Controls.Add(this.ptbLineas1);
            this.Controls.Add(this.pnlAzul);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.ptbSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diamond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diamond";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlAzul.ResumeLayout(false);
            this.pnlAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLineas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox ptbLineas3;
        private System.Windows.Forms.PictureBox ptbLineas2;
        private System.Windows.Forms.PictureBox ptbLineas1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblhasIngresado;
    }
}