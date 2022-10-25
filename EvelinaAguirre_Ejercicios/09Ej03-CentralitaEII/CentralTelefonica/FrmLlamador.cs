using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08Ej04_CentralitaEntidades;

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
                return this.central;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(EFranja));
            this.txtNroDestino.Text = "";
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(this.txtNroDestino.Text.StartsWith("#"))
            {
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }    
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = string.Empty;
            this.txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Llamada llamada;
            EFranja franja = EFranja.Franja_1;
            
            if(this.cmbFranja.Enabled)
            {
                Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(this.txtNroOrigen.Text, franja, rnd.Next(1, 50), this.txtNroDestino.Text);

            }
            else
            {
                double min = 0.5;
                double max = 5.6;

                llamada = new Local(this.txtNroOrigen.Text,rnd.Next(1,50),this.txtNroDestino.Text, (float)(rnd.NextDouble() * (min - max) + min));
            }
            this.central += llamada;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
