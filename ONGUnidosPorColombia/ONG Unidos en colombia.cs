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
    public partial class ONG_Unidos_en_colombia : Form
    {
        public ONG_Unidos_en_colombia()
        {
            InitializeComponent();
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
        }
        List<Trabajador> Trabajadores = new List<Trabajador>();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "ingrese el nombre del trabajador");
                txtNombre.Focus();
                txtNombre.Clear();
            }
            errorProvider1.SetError(txtNombre, "");
            if (txtEmpresa.Text == "")
            {
                errorProvider1.SetError(txtEmpresa, "ingrese el nombre del trabajador");
                txtEmpresa.Focus();
                txtEmpresa.Clear();
            }
            errorProvider1.SetError(txtEmpresa, "");
            if (txtHijos.Text == "")
            {
                errorProvider1.SetError(txtHijos, "ingrese el nombre del trabajador");
                txtHijos.Focus();
                txtHijos.Clear();
            }
            errorProvider1.SetError(txtHijos, "");
            int edad;
            if(!int.TryParse(txtHijos.Text, out edad))
            {
                errorProvider1.SetError(txtHijos, "Ingrese un valor numérico en la identificacion");
                txtHijos.Focus();
                txtHijos.Clear();
            }
            errorProvider1.SetError(txtHijos, "");

            Trabajador PersonaAyuda = new Trabajador();

            PersonaAyuda.Nombre_Trabajador = txtNombre.Text;
            PersonaAyuda.Nombre_Empresa = txtEmpresa.Text;
            PersonaAyuda.Total_Hijos = Convert.ToInt32( txtHijos.Text);
            PersonaAyuda.Fecha = DtpFecha.Value;
            TxtAyuda.Text = PersonaAyuda.calcular(PersonaAyuda.Total_Hijos).ToString();
            PersonaAyuda.TotalAuxilio =Convert.ToDecimal( TxtAyuda.Text);
            Trabajadores.Add(PersonaAyuda);

            DtgDatos.DataSource = null;
            DtgDatos.DataSource = Trabajadores.ToList();

            txtNombre.Clear();
            txtEmpresa.Clear();
            txtHijos.Clear();

            BtnBuscar.Enabled = true;
            

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

            }
            else
            {
                errorProvider1.SetError(txtNombre, "ingrese el nombre del producto");
                e.Handled = true;
            }
            errorProvider1.SetError(txtNombre,"");
        }

        private void filtro(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

            }
            else
            {
                errorProvider1.SetError(txtEmpresa, "ingrese el nombre del producto");
                e.Handled = true;
            }
            errorProvider1.SetError(txtEmpresa, "");
        }

        private Trabajador GetTrabajador(string Nombre)
        {
            foreach (Trabajador mitrabajador in Trabajadores)
            {
                if (mitrabajador.Nombre_Trabajador == Nombre)
                {
                    return mitrabajador;
                }
            }
            return null;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Trabajador mitrabajador = GetTrabajador(txtNombre.Text);
            if (mitrabajador == null)
            {
                errorProvider1.SetError(txtNombre, "el nombre del trabajador no se encuentra en la lista");
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
                txtNombre.Text = mitrabajador.Nombre_Trabajador;
                txtEmpresa.Text = mitrabajador.Nombre_Empresa;
                txtHijos.Text = mitrabajador.Total_Hijos.ToString();
                BtnEliminar.Enabled = true;
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(this, "Está seguro de eliminar el registro",
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                foreach (Trabajador mitrabajador in Trabajadores)
                {
                    if (mitrabajador.Nombre_Trabajador == txtNombre.Text)
                    {
                        Trabajadores.Remove(mitrabajador);
                        break;
                    }
                }
                txtNombre.Clear();
                txtEmpresa.Clear();
                txtHijos.Clear();
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Trabajadores;
            }
        }
    }
}
