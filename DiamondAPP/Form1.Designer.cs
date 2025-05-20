namespace DiamondAPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.linkrestablecer = new System.Windows.Forms.LinkLabel();
            this.btnacceder = new System.Windows.Forms.Button();
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 58F);
            this.label1.Location = new System.Drawing.Point(161, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 97);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Font = new System.Drawing.Font("Arial Narrow", 35F);
            this.line1.Location = new System.Drawing.Point(86, 183);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(444, 55);
            this.line1.TabIndex = 3;
            this.line1.Text = "____________________";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Font = new System.Drawing.Font("Arial Narrow", 35F);
            this.line2.Location = new System.Drawing.Point(86, 292);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(444, 55);
            this.line2.TabIndex = 4;
            this.line2.Text = "____________________";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Location = new System.Drawing.Point(96, 308);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(420, 25);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.Text = "INGRESA TU CONTRASEÑA";
            this.txtcontraseña.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontraseña.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // linkrestablecer
            // 
            this.linkrestablecer.AutoSize = true;
            this.linkrestablecer.BackColor = System.Drawing.Color.Transparent;
            this.linkrestablecer.LinkColor = System.Drawing.Color.White;
            this.linkrestablecer.Location = new System.Drawing.Point(188, 626);
            this.linkrestablecer.Name = "linkrestablecer";
            this.linkrestablecer.Size = new System.Drawing.Size(218, 25);
            this.linkrestablecer.TabIndex = 0;
            this.linkrestablecer.TabStop = true;
            this.linkrestablecer.Text = "¿olvidaste tu contraseña?";
            // 
            // btnacceder
            // 
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnacceder.Location = new System.Drawing.Point(324, 507);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(190, 55);
            this.btnacceder.TabIndex = 6;
            this.btnacceder.Text = "ACCEDE";
            this.btnacceder.UseVisualStyleBackColor = true;
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.FlatAppearance.BorderSize = 0;
            this.btnregistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnregistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrarse.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnregistrarse.Location = new System.Drawing.Point(98, 507);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(190, 55);
            this.btnregistrarse.TabIndex = 5;
            this.btnregistrarse.Text = "REGISTRATE";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Location = new System.Drawing.Point(94, 195);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(420, 25);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Text = "INGRESA TU USUARIO";
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(557, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(40, 36);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Enter += new System.EventHandler(this.btnsalir_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiamondAPP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 678);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnregistrarse);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.linkrestablecer);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.LinkLabel linkrestablecer;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Button btnregistrarse;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnsalir;
    }
}

