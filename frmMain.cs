using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjercicioxResolverSP3
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }
        public struct CONSULTA
        {
            public int NumeroRepuesto;
            public string Descripcion;
            public string Marca;
            public string Origen;
            public float Precio;
        }
        const int MAX = 100;
        public CONSULTA[] Consulta;
        public int Cantidad;

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            Consulta = new CONSULTA[MAX];
            Cantidad = 0;
            InicializarInterfaz();
        }
        public void InicializarInterfaz()
        {
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Peugeot");
            cmbMarca.Items.Add("Fiat");
            cmbMarca.Items.Add("Renault");
            cmbMarca2.Items.Clear();
            cmbMarca2.Items.Add("Peugeot");
            cmbMarca2.Items.Add("Fiat");
            cmbMarca2.Items.Add("Renault");
            cmbOrigen.Items.Clear();
            cmbOrigen.Items.Add("Nacional");
            cmbOrigen.Items.Add("Importado");
            cmbMarca.SelectedIndex = 0;
            cmbOrigen.SelectedIndex = 0;
            optNacional.Checked = true;
            btnConsultar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void txtNumeroRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public void Control()
        {
            if (txtDescripcion.Text != ""
                && txtNumeroRepuesto.Text != ""
                && txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtNumeroRepuesto_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Control();
        }
        private bool ValidarDatos()
        {
            bool resultado = false;

            if (txtDescripcion.Text != "" && txtNumeroRepuesto.Text != "" && txtPrecio.Text != "")
            {
                if (!BuscarTurno(int.Parse(txtNumeroRepuesto.Text)))
                {
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("El número de respuesto ingresado ya existe",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        private bool BuscarTurno(int numero)
        {
            bool existe = false;
            int i = 0;

            while (i < Cantidad)
            {
                if (numero == Consulta[i].NumeroRepuesto)
                {
                    existe = true;
                    break;
                }
                i++;
            }
            return existe;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                Consulta[Cantidad].NumeroRepuesto = int.Parse(txtNumeroRepuesto.Text);
                Consulta[Cantidad].Descripcion = txtDescripcion.Text;
                Consulta[Cantidad].Precio = int.Parse(txtPrecio.Text);
                Consulta[Cantidad].Marca = cmbMarca.Text;
                Consulta[Cantidad].Origen = cmbOrigen.Text;
                Cantidad++;
                MessageBox.Show("Datos cargados exitosamente", "ATENCIÓN",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Cantidad == MAX)
            {
                MessageBox.Show("Se completó la capacidad de carga de datos",
                "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRegistrar.Enabled = false;
            }
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtNumeroRepuesto.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstConsulta.Items.Clear();
            for (int i = 0; i < Consulta.Length; i++)
            {
                if (Consulta[i].Marca == cmbMarca2.Text)
                {
                    if (optNacional.Checked == true && Consulta[i].Origen == "Nacional")
                    {
                        lstConsulta.Items.Add("Número de repuesto: " + Consulta[i].NumeroRepuesto);
                        lstConsulta.Items.Add("Descripción: " + Consulta[i].Descripcion);
                        lstConsulta.Items.Add("Precio: $" + Consulta[i].Precio);
                    }
                    else
                    {
                        if (optImportado.Checked == true && Consulta[i].Origen == "Importado")
                        {
                            lstConsulta.Items.Add("Número de repuesto: " + Consulta[i].NumeroRepuesto);
                            lstConsulta.Items.Add("Descripción: " + Consulta[i].Descripcion);
                            lstConsulta.Items.Add("Precio: $" + Consulta[i].Precio);
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarca2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca2.SelectedIndex != -1)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }
    }
    
}
