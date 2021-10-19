using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bicicleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Bicicleta bicicleta = new Bicicleta(cbMarca.Text, cbEstilo.Text, cbColor.Text, txtPrecio.Text);

            listBox1.Items.Add(bicicleta.mostrarbike());
            cbMarca.Text = "";
            cbEstilo.Text = "";
            cbColor.Text = "";
            txtPrecio.Text = "";
        }
    }
}
