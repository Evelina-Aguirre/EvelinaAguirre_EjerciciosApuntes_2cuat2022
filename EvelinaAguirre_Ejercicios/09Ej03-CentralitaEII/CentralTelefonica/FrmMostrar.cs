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
            this.rchMostrar.Text = central.ToString()+"\n";

            foreach (Llamada item in central.Llamadas)
            {
                if(this.tipoLlamada is ETipoLlamada.Todas)
                {
                this.rchMostrar.Text += $"Llamada {contador++}\n";
                this.rchMostrar.Text += item.ToString();

                }
                else if(this.tipoLlamada is ETipoLlamada.Local && item is Local)
                {
                    this.rchMostrar.Text += $"Llamada {contador++}\n";
                    this.rchMostrar.Text += item.ToString();
                }
                else if(this.tipoLlamada is ETipoLlamada.Provincial && item is Provincial)
                {
                    this.rchMostrar.Text += $"Llamada {contador++}\n";
                    this.rchMostrar.Text += item.ToString();
                }
            }

        }
    }
}
