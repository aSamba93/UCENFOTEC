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
        //evento que setea el numero al presionarse
        public void agregarNum(object sender, EventArgs ev)
        {
            var btn = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += btn.Text;
        }
        //metodo que imprime el resultado de acuerdo a la accion aritmetica
        private void btnIgual_Click(object sender, EventArgs ev)
        {
            string result = txtResultado.Text;
            if (result.Contains(","))
                txtResultado.Text = result.Replace(",", ".");
            numero2 = Convert.ToDouble(txtResultado.Text);
            try
            {
                if (accion == "none")
                {
                    txtResultado.Text = txtResultado.Text;
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                if (accion == "+")
                {
                    txtResultado.Text = (numero1 + numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = reemplazar(numero1);
                    accion = "none";
                }
                else if (accion == "-")
                {
                    txtResultado.Text = (numero1 - numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = reemplazar(numero1);
                    accion = "none";
                }
                else if (accion == "*")
                {
                    txtResultado.Text = (numero1 * numero2).ToString();
                    numero2 = Convert.ToDouble(txtResultado.Text);
                    accion = "none";
                }
                else if (accion == "/")
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                    accion = "none";
                }

                Validar();
            }
            catch (Exception exc)
            {                
                Console.WriteLine(exc);
            }
        }    
        
        
        public void onClickAccion(object sender, EventArgs ev)
        {
            var boton = (Button)sender;
            string result = txtResultado.Text;
            if (result.Contains(","))
                txtResultado.Text = result.Replace(",", ".");
            numero1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
            accion = (boton.Text).ToString();
        }  
        //metododo que reemplaza el . por una coma
        public string reemplazar(double valor)
        {
            string result = valor.ToString();
            if (result.Contains("."))
                result = result.Replace(".", ",");
            return result;
        }

        private void btnAtras_Click(object sender, EventArgs ev)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnMC_Click(object sender, EventArgs ev)
        {
            numero1 = 0;
            numero2 = 0;
        }

        private void btnMR_Click(object sender, EventArgs ev)
        {
            txtResultado.Text = numero2.ToString();
        }

        private void btnMS_Click(object sender, EventArgs ev)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void btnMSuma_Click(object sender, EventArgs ev)
        {
            numero2 = (Convert.ToDouble(txtResultado.Text) + numero2);
            txtResultado.Text = "0";
            Validar();
        }

        private void btnMResta_Click(object sender, EventArgs ev)
        {
            numero2 = (Convert.ToDouble(txtResultado.Text) - numero2);
            txtResultado.Text = "0";
            Validar();
        }

        private void btnCE_Click(object sender, EventArgs ev)
        {
            txtResultado.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs ev)
        {
            numero1 = 0;
            numero2 = 0;
            accion = "\0";
            txtResultado.Text = "0";
        }

        private void btnMasMenos_Click(object sender, EventArgs ev)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        //metodo que valida no excederse de mas de 10 caracteres
        public void Validar()
        {            
            if (txtResultado.Text.Length > 10)
                txtResultado.Text = "FUERA DE RANGO";
        }
        
    }
}
