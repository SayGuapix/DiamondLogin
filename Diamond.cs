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
    public partial class Diamond : Form
    {
        public Diamond(string usuario, string correo, string curso)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblCorreo.Text = correo;
            lblCurso.Text = curso;
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbSalir_MouseMove(object sender, MouseEventArgs e)
        {
            lblSalir.Visible = true;
        }

        private void ptbSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Sesion form = new Sesion();
            form.Show();
            this.Hide();
        }
    }
}
