using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONGUnidosPorColombia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "123")
            {
                Hide();
                ONG_Unidos_en_colombia Nuevo = new ONG_Unidos_en_colombia();
                Nuevo.Show();
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "Digite la contraseña correctamente");
                txtContraseña.Focus();
                txtContraseña.Clear();
                return;
            }
            errorProvider1.SetError(txtContraseña, "");
        }
    }
}
