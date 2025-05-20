using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiamondAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text == "INGRESA TU USUARIO")
            {
                txtusuario.Text = "";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "INGRESA TU USUARIO";
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if(txtcontraseña.Text == "INGRESA TU CONTRASEÑA")
            {
                txtcontraseña.Text = "";
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "INGRESA TU CONTRASEÑA";
            }
        }

        private void btnsalir_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
