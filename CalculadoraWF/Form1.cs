using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWF
{
    public partial class formCalc : Form
    {
        double numero1, numero2 = 0;
        string accion;
        public formCalc()
        {
            InitializeComponent();
        }  
        public void agregarNum(object sender, EventArgs ev)
        {
            var btn = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += btn.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exc)
            {
                txtResultado.Text = "ERROR DE SINTAXIS";
                Console.WriteLine(exc);
            }
        }

        public void Validar()
        {
            if (txtResultado.Text.Length > 10)
                txtResultado.Text = "FUERA DE RANGO";
        }
    }
}
