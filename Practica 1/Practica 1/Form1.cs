using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrown_Click(object sender, EventArgs e)
        {
            float N1, N2,resultado;
            N1 = Convert.ToSingle(txtNumero1.Text);
            N2 = Convert.ToSingle(txtNumero2.Text);
            resultado = N1 + N2;

            txtResultado.Text = Convert.ToString(resultado);
        }
    }
}
