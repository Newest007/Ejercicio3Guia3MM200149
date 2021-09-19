using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3___Guía3_MM200149
{
    public partial class Form1 : Form
    {

        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvlistado.Visible = false;
            listadoproduct.Visible = false;
            btneliminar.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listadoproduct.Visible = true;
            dtgvlistado.Visible = true;
            btneliminar.Visible = true;
        }
    }
}
