using _08Ej04_CentralitaEntidades;
using Entidades;
using System;
using System.Windows.Forms;

/*Agregar los formularios FrmLlamador y FrmMostrar:

Recibirán en su constructor a la instancia de Centralita creada en FrmMenu.x
FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita, a fin de volver a ser leída por el formulario de menú una vez terminada la acción.
Si se presiona el botón btnGenerarLlamada abrir un nuevo formulario de forma modal:

Si la llamada comienza con #, es provincial. Si la llamada no comienza con #, se deberá poner el combo cmbFranja en estado deshabilitado.
La fuente de txtNroDestino será 16. Este TextBox sólo se podrá cargar mediante el panel numérico.
El panel numérico se encontrará dentro de un Groupbox con el título "Panel".
El TextBox situado por debajo del botón btnLimpiar será el txtNroOrigen.
La duración será un número aleatorio entre 1 y 50.
El costo, en caso de necesitarlo, será un número aleatorio entre 0,5 y 5,6.
El combo cmbFranja, situado al final del formulario, será el encargado de colocar una franja horaria a las llamadas provinciales.*/

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        Centralita central;
        public FrmLlamador(Centralita central)
        {
            this.central = central;
            InitializeComponent();
        }

        public Centralita Central
        {
            get
            {
                return central;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(EFranja));
            txtNroDestino.Text = "";
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Llamada llamada;
            EFranja franja = EFranja.Franja_1;

            if (cmbFranja.Enabled)
            {
                Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(txtNroOrigen.Text, franja, rnd.Next(1, 50), txtNroDestino.Text);

            }
            else
            {
                double min = 0.5;
                double max = 5.6;

                llamada = new Local(txtNroOrigen.Text, rnd.Next(1, 50), txtNroDestino.Text, (float)(rnd.NextDouble() * (min - max) + min));
            }

            try
            {
                central += llamada;
            }
            catch (CentralitaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
