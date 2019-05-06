using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pelotal;

namespace Ventapelota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Grafica pel;
        private void button1_Click(object sender, EventArgs e)
        {

            //string color = comboBox1.SelectedItem.ToString();
            //if (color!=null)
            //    {
            //    string color = comboBox1.SelectedItem.ToString();
            //    Random alaza = new Random();
            //    int alazar;
            //    alazar = alaza.Next(1, 5);
            //    pel.Animacion(pictureBox1, alazar, color);
            //}

            try
            {
               
                string color = comboBox1.SelectedItem.ToString();
                Random alaza = new Random();
                int alazar;
                alazar = alaza.Next(1, 5);
                pel.Animacion(pictureBox1, alazar, color);
                MessageBox.Show("el ultimo color que seleccionaste fue "+ color.ToString());
                MessageBox.Show("verdad que no fue tan dificil seleccionar un color compa jeje");

            }
            catch
            {
           
                MessageBox.Show("seleccione porfavor un color de la lista desplegable cabron perro");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pel = new Grafica(pictureBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
