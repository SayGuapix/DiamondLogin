namespace DIAMOND
{
    partial class Sesion
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
            this.components = new System.ComponentModel.Container();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ptbAyuda = new System.Windows.Forms.PictureBox();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.ptbContraseña = new System.Windows.Forms.PictureBox();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbLinea1 = new System.Windows.Forms.PictureBox();
            this.ptbLinea2 = new System.Windows.Forms.PictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblAlerta1 = new System.Windows.Forms.Label();
            this.lblAlerta2 = new System.Windows.Forms.Label();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLinea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLinea2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(1, 481);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(667, 96);
            this.btnAcceder.TabIndex = 8;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            this.btnAcceder.MouseLeave += new System.EventHandler(this.btnAcceder_MouseLeave);
            this.btnAcceder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAcceder_MouseMove);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(1, 578);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(667, 95);
            this.btnRegistrarse.TabIndex = 10;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.tbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsuario.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.tbxUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxUsuario.Location = new System.Drawing.Point(165, 195);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(411, 38);
            this.tbxUsuario.TabIndex = 10;
            this.tbxUsuario.Text = "USUARIO";
            this.tbxUsuario.Enter += new System.EventHandler(this.tbxUsuario_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.tbxUsuario_Leave);
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.tbxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContraseña.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.tbxContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxContraseña.Location = new System.Drawing.Point(167, 312);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.Size = new System.Drawing.Size(411, 38);
            this.tbxContraseña.TabIndex = 9;
            this.tbxContraseña.Text = "CONTRASEÑA";
            this.tbxContraseña.Enter += new System.EventHandler(this.tbxContraseña_Enter);
            this.tbxContraseña.Leave += new System.EventHandler(this.tbxContraseña_Leave);
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lblDescripcion1.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion1.Location = new System.Drawing.Point(560, 23);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(49, 24);
            this.lblDescripcion1.TabIndex = 34;
            this.lblDescripcion1.Text = "Salir";
            this.lblDescripcion1.Visible = false;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lblDescripcion2.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion2.Location = new System.Drawing.Point(61, 23);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(61, 24);
            this.lblDescripcion2.TabIndex = 35;
            this.lblDescripcion2.Text = "Ayuda";
            this.lblDescripcion2.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.lblLogo.Font = new System.Drawing.Font("Constantia", 17F);
            this.lblLogo.ForeColor = System.Drawing.Color.LightCyan;
            this.lblLogo.Location = new System.Drawing.Point(276, 59);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(127, 28);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "DIAMOND";
            // 
            // ptbAyuda
            // 
            this.ptbAyuda.Image = global::DIAMOND.Properties.Resources.Informacion;
            this.ptbAyuda.Location = new System.Drawing.Point(12, 13);
            this.ptbAyuda.Name = "ptbAyuda";
            this.ptbAyuda.Size = new System.Drawing.Size(43, 43);
            this.ptbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAyuda.TabIndex = 10;
            this.ptbAyuda.TabStop = false;
            this.ptbAyuda.Click += new System.EventHandler(this.ptbAyuda_Click);
            this.ptbAyuda.MouseLeave += new System.EventHandler(this.ptbAyuda_MouseLeave);
            this.ptbAyuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbAyuda_MouseMove);
            // 
            // ptbSalir
            // 
            this.ptbSalir.Image = global::DIAMOND.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(615, 12);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(43, 43);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 9;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            this.ptbSalir.MouseLeave += new System.EventHandler(this.ptbSalir_MouseLeave);
            this.ptbSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbSalir_MouseMove);
            // 
            // ptbContraseña
            // 
            this.ptbContraseña.Image = global::DIAMOND.Properties.Resources.Contraseña;
            this.ptbContraseña.Location = new System.Drawing.Point(103, 310);
            this.ptbContraseña.Name = "ptbContraseña";
            this.ptbContraseña.Size = new System.Drawing.Size(43, 43);
            this.ptbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbContraseña.TabIndex = 2;
            this.ptbContraseña.TabStop = false;
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::DIAMOND.Properties.Resources.Usuario;
            this.ptbUsuario.Location = new System.Drawing.Point(105, 195);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(41, 41);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuario.TabIndex = 1;
            this.ptbUsuario.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::DIAMOND.Properties.Resources.Logo;
            this.ptbLogo.Location = new System.Drawing.Point(274, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(129, 123);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // ptbLinea1
            // 
            this.ptbLinea1.Image = global::DIAMOND.Properties.Resources.Linea;
            this.ptbLinea1.Location = new System.Drawing.Point(103, 229);
            this.ptbLinea1.Name = "ptbLinea1";
            this.ptbLinea1.Size = new System.Drawing.Size(475, 40);
            this.ptbLinea1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLinea1.TabIndex = 3;
            this.ptbLinea1.TabStop = false;
            // 
            // ptbLinea2
            // 
            this.ptbLinea2.Image = global::DIAMOND.Properties.Resources.Linea;
            this.ptbLinea2.Location = new System.Drawing.Point(103, 347);
            this.ptbLinea2.Name = "ptbLinea2";
            this.ptbLinea2.Size = new System.Drawing.Size(475, 40);
            this.ptbLinea2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLinea2.TabIndex = 4;
            this.ptbLinea2.TabStop = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lblAviso.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblAviso.Location = new System.Drawing.Point(238, 454);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(197, 24);
            this.lblAviso.TabIndex = 38;
            this.lblAviso.Text = "Llena todos los campos";
            this.lblAviso.Visible = false;
            // 
            // lblAlerta1
            // 
            this.lblAlerta1.AutoSize = true;
            this.lblAlerta1.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblAlerta1.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblAlerta1.Location = new System.Drawing.Point(315, 195);
            this.lblAlerta1.Name = "lblAlerta1";
            this.lblAlerta1.Size = new System.Drawing.Size(23, 38);
            this.lblAlerta1.TabIndex = 45;
            this.lblAlerta1.Text = "!";
            this.lblAlerta1.Visible = false;
            // 
            // lblAlerta2
            // 
            this.lblAlerta2.AutoSize = true;
            this.lblAlerta2.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblAlerta2.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblAlerta2.Location = new System.Drawing.Point(377, 313);
            this.lblAlerta2.Name = "lblAlerta2";
            this.lblAlerta2.Size = new System.Drawing.Size(23, 38);
            this.lblAlerta2.TabIndex = 46;
            this.lblAlerta2.Text = "!";
            this.lblAlerta2.Visible = false;
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lblAviso2.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAviso2.Location = new System.Drawing.Point(238, 454);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(192, 24);
            this.lblAviso2.TabIndex = 47;
            this.lblAviso2.Text = "Contraseña incorrecta";
            this.lblAviso2.Visible = false;
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(670, 674);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.lblAlerta2);
            this.Controls.Add(this.lblAlerta1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblDescripcion2);
            this.Controls.Add(this.lblDescripcion1);
            this.Controls.Add(this.ptbAyuda);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.ptbContraseña);
            this.Controls.Add(this.ptbUsuario);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.ptbLinea1);
            this.Controls.Add(this.ptbLinea2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "Sesion";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLinea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLinea2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.PictureBox ptbContraseña;
        private System.Windows.Forms.PictureBox ptbLinea1;
        private System.Windows.Forms.PictureBox ptbLinea2;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.PictureBox ptbAyuda;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblAlerta1;
        private System.Windows.Forms.Label lblAlerta2;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Timer Tiempo;
    }
}

