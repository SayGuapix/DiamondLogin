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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "USUARIO")
            {
                tbxUsuario.Clear();
            }
            lblDescripcion1.Visible = true;
            tbxUsuario.ForeColor = Color.White;
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "")
            {
                tbxUsuario.Text = "USUARIO";
                tbxUsuario.ForeColor = Color.DarkGray;
            }
            lblDescripcion1.Visible = false;
        }

        private void tbxCorreo_Enter(object sender, EventArgs e)
        {
            if (tbxCorreo.Text == "CORREO")
            {
                tbxCorreo.Clear();
            }
            lblDescripcion2.Visible = true;
            tbxCorreo .ForeColor = Color.White;
        }

        private void tbxCorreo_Leave(object sender, EventArgs e)
        {
            if (tbxCorreo.Text == "")
            {
                tbxCorreo.Text = "CORREO";
                tbxCorreo.ForeColor = Color.DarkGray;
            }
            lblDescripcion2.Visible = false;
        }

        private void tbxCurso_Enter(object sender, EventArgs e)
        {
            if (tbxCurso.Text == "CURSO")
            {
                tbxCurso.Clear();
            }
            lblDescripcion3.Visible = true;
            tbxCurso .ForeColor = Color.White;
        }

        private void tbxCurso_Leave(object sender, EventArgs e)
        {
            if (tbxCurso.Text == "")
            {
                tbxCurso.Text = "CURSO";
                tbxCurso.ForeColor = Color.DarkGray;
            }
            lblDescripcion3.Visible = false;
        }

        private void tbxContraseña_Enter(object sender, EventArgs e)
        {
            if (tbxContraseña.Text == "CONTRASEÑA")
            {
                tbxContraseña.Clear();
            }
            lblDescripcion4.Visible = true;
            tbxContraseña .ForeColor = Color.White;
        }

        private void tbxContraseña_Leave(object sender, EventArgs e)
        {
            if (tbxContraseña.Text == "")
            {
                tbxContraseña.Text = "CONTRASEÑA";
                tbxContraseña.ForeColor = Color.DarkGray;
            }
            lblDescripcion4.Visible = false;
        }
        private bool ValidarCampos()
        {
            //Verifica si los campos estan vacios.

            string valorUsuario = "USUARIO";
            string valorCorreo = "CORREO";
            string valorCurso = "CURSO";
            string valorContraseña = "CONTRASEÑA";

            if (tbxUsuario.Text == valorUsuario)
            {
                lblAlerta1.Visible = true;
            }else
            {
                lblAlerta1.Visible = false;
            }
            if (tbxCorreo.Text == valorCorreo)
            {
                lblAlerta2.Visible = true;
            }else
            {
                lblAlerta2.Visible = false;
            }
            if (tbxCurso.Text == valorCurso)
            {
                lblAlerta3.Visible = true;
            }else
            {
                lblAlerta3.Visible = false;
            }
            if (tbxContraseña.Text == valorContraseña)
            {
                lblAlerta4.Visible = true;
            }else
            {
                lblAlerta4.Visible = false;
            }

            return !string.IsNullOrWhiteSpace(tbxUsuario.Text) &&
                   tbxUsuario.Text.ToUpper() != valorUsuario &&
                   !string.IsNullOrWhiteSpace(tbxCorreo.Text) &&
                   tbxCorreo.Text.ToUpper() != valorCorreo &&
                   !string.IsNullOrWhiteSpace(tbxCurso.Text) &&
                   tbxCurso.Text.ToUpper() != valorCurso &&
                   !string.IsNullOrWhiteSpace(tbxContraseña.Text) &&
                   tbxContraseña.Text.ToUpper() != valorContraseña;
        }

        private void ptbBorrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion5.Visible = true;
        }

        private void ptbBorrar_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion5.Visible = false;
        }

        private void ptbSalir_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion6.Visible = true;
        }

        private void ptbSalir_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion6.Visible = false;
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbBorrar_Click(object sender, EventArgs e)
        {
            tbxUsuario.Text = "USUARIO";
            tbxCorreo.Text = "CORREO";
            tbxCurso.Text = "CURSO";
            tbxContraseña.Text = "CONTRASEÑA";

            ptbBorrar.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Sesion form = new Sesion();
            form.Show();
            this.Hide();
        }

        private void btnCrear_MouseMove(object sender, MouseEventArgs e)
        {
            ValidarCampos();
        }

        private void btnCrear_MouseLeave(object sender, EventArgs e)
        {
            lblAlerta1.Visible = false;
            lblAlerta2.Visible= false;
            lblAlerta3.Visible = false;
            lblAlerta4.Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string usuario = tbxUsuario.Text;
                string correo = tbxCorreo.Text;
                string curso = tbxCurso.Text;
                string contraseña = tbxContraseña.Text;

                if (ConexionDB.RegistrarUsuario(usuario, correo, curso, contraseña))
                {
                    MessageBox.Show("Registro exitoso.");
                    Sesion sesionForm = new Sesion();
                    sesionForm.Show();
                    this.Close();
                }
            }
        }
    }
}
