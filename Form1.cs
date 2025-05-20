using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIAMOND
{
    public partial class Sesion : Form
    {
        private static int intentosFallidos = 0;
        private const int maxIntentos = 3;
        private const int tiempoEspera = 30;
        private int tiempoRestante = tiempoEspera;

        public Sesion()
        {
            InitializeComponent();
            Tiempo.Interval = 1000; 
            Tiempo.Tick += Tiempo_Tick;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
            }
            else
            {
                Tiempo.Stop();
                intentosFallidos = 0;
                tiempoRestante = tiempoEspera; 
            }
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "USUARIO")
            {
                tbxUsuario.Clear();
                lblAviso.Visible = false;
                lblAviso2.Visible = false;
            }
            tbxUsuario.ForeColor = Color.White;
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "")
            {
                tbxUsuario.Text = "USUARIO";
                tbxUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void tbxContraseña_Enter(object sender, EventArgs e)
        {
            if (tbxContraseña.Text == "CONTRASEÑA")
            {
                tbxContraseña.Clear();
                tbxContraseña.UseSystemPasswordChar = true;
                lblAviso.Visible = false;
                lblAviso2.Visible = false;
            }
            tbxContraseña.ForeColor = Color.White;
        }

        private void tbxContraseña_Leave(object sender, EventArgs e)
        {
            if (tbxContraseña.Text == "")
            {
                tbxContraseña.Text = "CONTRASEÑA";
                tbxContraseña.UseSystemPasswordChar = false;
                tbxContraseña.ForeColor = Color.DarkGray;
            }
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbSalir_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion1.Visible = true;
        }

        private void ptbSalir_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion1.Visible = false;
        }

        private void ptbAyuda_Click(object sender, EventArgs e)
        {

        }

        private void ptbAyuda_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion2.Visible = true;
        }

        private void ptbAyuda_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion2.Visible = false;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (ValidarSesion())
            {
                string usuario = tbxUsuario.Text;
                string contraseña = tbxContraseña.Text;

                if (intentosFallidos >= maxIntentos)
                {
                    Tiempo.Start();
                    return;
                }

                if (ConexionDB.IniciarSesion(usuario, contraseña))
                {
                    var datosUsuario = ConexionDB.ObtenerDatosUsuario(usuario);
                    if (datosUsuario.Usuario != null)
                    {
                        Diamond diamondForm = new Diamond(datosUsuario.Usuario, datosUsuario.Correo, datosUsuario.Curso);
                        diamondForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron los datos del usuario.");
                    }
                }
                else
                {
                    lblAviso2.Visible = true;
                }
            }
            else
            {
                lblAviso.Visible = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse form = new Registrarse();
            form.Show();
            this.Hide();
        }

        private void btnAcceder_MouseMove(object sender, MouseEventArgs e)
        {
            ValidarSesion();
        }

        private void btnAcceder_MouseLeave(object sender, EventArgs e)
        {
            lblAlerta1.Visible = false;
            lblAlerta2.Visible = false;
        }

        private bool ValidarSesion()
        {
            string valorUsuario = "USUARIO";
            string valorContraseña = "CONTRASEÑA";

            if (tbxUsuario.Text == valorUsuario)
            {
                lblAlerta1.Visible = true;
            }
            else
            {
                lblAlerta1.Visible = false;
            }
            if (tbxContraseña.Text == valorContraseña)
            {
                lblAlerta2.Visible = true;
            }
            else
            {
                lblAlerta2.Visible = false;
            }

            return !string.IsNullOrWhiteSpace(tbxUsuario.Text) &&
                   tbxUsuario.Text.ToUpper() != valorUsuario &&
                   !string.IsNullOrWhiteSpace(tbxContraseña.Text) &&
                   tbxContraseña.Text.ToUpper() != valorContraseña;
        }
    }
}
