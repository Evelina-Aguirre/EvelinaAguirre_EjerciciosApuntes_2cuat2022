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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Programación");
            this.comboBox1.Items.Add("Labo");
            this.comboBox1.Items.Add("Estadistica");
            this.comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.textBox1.Text) && string.IsNullOrWhiteSpace( this.textBox2.Text ))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre\nApellido");
            }
            
            if(string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre");
            }
            
            if(string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre");
            }
            Saludar_05Ej01 saludar = new Saludar_05Ej01();
            saludar.MensajeEnPantalla(this.textBox1.Text, this.textBox2.Text, this.comboBox1.Text);
            saludar.Show();
            this.Hide();
        }
    }
}
