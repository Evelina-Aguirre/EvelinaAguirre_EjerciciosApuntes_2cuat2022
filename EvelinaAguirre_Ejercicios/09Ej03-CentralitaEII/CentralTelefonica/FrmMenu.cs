using _08Ej04_CentralitaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTelefonica
{
    /*Si se presiona alguno de los botones btnFacturacionTotal, btnFacturacionLocal o btnFacturacionProvincial, 
     * abrir un formulario sólo con un RichTextBox y la información correspondiente impresa en él.

    El formulario tendrá un atributo del tipo TipoLlamada, y una propiedad de sólo escritura para cargarle datos y
    así saber qué llamadas mostrar.
    Todos los formularios deberán aparecer centrados, el principal en la pantalla y el resto con respecto al principal.*/
    public partial class FrmMenu : Form
    {
        Centralita central = new Centralita();
        ETipoLlamada tipoLlamada;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(central);
            frmLlamador.ShowDialog();
            this.central = frmLlamador.Central;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(central, ETipoLlamada.Todas);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(central, ETipoLlamada.Local);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(central, ETipoLlamada.Provincial);
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
