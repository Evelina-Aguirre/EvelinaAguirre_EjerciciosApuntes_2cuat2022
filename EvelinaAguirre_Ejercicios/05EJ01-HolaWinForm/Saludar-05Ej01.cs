using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05EJ01_HolaWinForm
{
    public partial class Saludar_05Ej01 : Form
    {
        public Saludar_05Ej01()
        {
            InitializeComponent();
        }

        private void Saludar_05Ej01_Load(object sender, EventArgs e)
        {

        }

        public void MensajeEnPantalla(string nombre, string apellido, string materia)
        {
            this.lbl_saludoPersonalizado.Text = $"Soy {nombre} {apellido} \n Mi materia favorita es : {materia}";
        }

    }
}
