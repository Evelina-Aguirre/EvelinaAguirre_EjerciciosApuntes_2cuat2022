using _08Ej04_CentralitaEntidades;
using System;
using System.Windows.Forms;

namespace CentralTelefonica
{
    public partial class FrmMostrar : Form
    {
        private Centralita central;
        ETipoLlamada tipoLlamada;
        public FrmMostrar(Centralita central, ETipoLlamada tipoLlamada)
        {
            this.central = central;
            this.tipoLlamada = tipoLlamada;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            int contador = 1;
            rchMostrar.Text = central.ToString() + "\n";

            foreach (Llamada item in central.Llamadas)
            {
                if (tipoLlamada is ETipoLlamada.Todas)
                {
                    rchMostrar.Text += $"Llamada {contador++}\n";
                    rchMostrar.Text += item.ToString();

                }
                else if (tipoLlamada is ETipoLlamada.Local && item is Local)
                {
                    rchMostrar.Text += $"Llamada {contador++}\n";
                    rchMostrar.Text += item.ToString();
                }
                else if (tipoLlamada is ETipoLlamada.Provincial && item is Provincial)
                {
                    rchMostrar.Text += $"Llamada {contador++}\n";
                    rchMostrar.Text += item.ToString();
                }
            }

        }
    }
}
