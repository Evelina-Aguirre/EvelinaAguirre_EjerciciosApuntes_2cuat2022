using System;
using System.Windows.Forms;

namespace _05Ej02_registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            string generoSeleccionado = string.Empty;
            int algoSeleccionado = 0;
            
                foreach (RadioButton radioB in grpGenero.Controls)
                {
                    if (radioB.Checked)
                    {
                        generoSeleccionado = radioB.Name;
                    algoSeleccionado++;
                    }

                }

            if (algoSeleccionado == 0)
            {
                generoSeleccionado = "indefinido";
            }

            
            

            string[] cursosSelecionados = new string[3];
            int indexChkBox = 0;
            int algoSeleccionado1 = 0;

            foreach (CheckBox chkBox in this.grpCursos.Controls)
            {
                    if(chkBox.Checked)
                    {
                        cursosSelecionados[indexChkBox] = chkBox.Name;
                        indexChkBox++;
                    }
               
            }
            if(algoSeleccionado1 ==0)
            {
                cursosSelecionados[0] = "Ninguno";
            }

          

            Ingresante ingresante = new Ingresante(textBox1.Text, textBox2.Text, generoSeleccionado, this.lstPais.SelectedItem.ToString(), cursosSelecionados, (int)this.numericUpDown1.Value);
            MessageBox.Show(ingresante.Mostrar());
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
