using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPClculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);
            string operador = cmbOperador.Text;
            resultado =  Calculadora.operar(numero1, numero2, operador);
            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = ("");
        }

        
    }
}
