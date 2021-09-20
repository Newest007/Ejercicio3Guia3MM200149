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

            btningresardat.Visible = false;


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
            gbxingresar.Visible = false;
            btningresardat.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbxingresar.Visible = true;
            listadoproduct.Visible = false;
            dtgvlistado.Visible = false;
            btneliminar.Visible = false;
            btningresardat.Visible = false;
        }


        private void ActualizarGrid()
        {
            dtgvlistado.DataSource = null;
            dtgvlistado.DataSource = Productos;
        }

        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dtgvlistado.SelectedRows[0];
            int posicion = dtgvlistado.Rows.IndexOf(selected);
            edit_indice = posicion;

            Producto product = Productos[posicion];

            txtnombre.Text = product.Nombre;
            txtdescripcion.Text = product.Descripcion;
            txtmarca.Text = product.Marca;
            txtprecio.Text = Convert.ToString(product.Precio);
            txtstock.Text = Convert.ToString(product.Stock);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Descripcion = txtdescripcion.Text;
            product.Marca = txtmarca.Text;
  
            product.Precio = float.Parse(txtprecio.Text);
            product.Stock = int.Parse(txtstock.Text);

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/
            }

            ActualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }

        }
    }
}
