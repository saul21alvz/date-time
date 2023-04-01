using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            if (txtnombre.Text == "")
            {
                MessageBox.Show("Estoy vacia");
            }
            else
            {
                StreamWriter fichero;
                fichero = File.AppendText("fecha-n.txt");//se crea txt
                fichero.WriteLine(txtnombre.Text+"-"+fecha.ToString());
                fichero.Close();
                MessageBox.Show("Se guardaron los datos");
            }

            

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 58)
            {
                e.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
