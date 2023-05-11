using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace calcientifica
{
    public partial class Form1 : Form
    {
        Double cont, activon2, n1, n2, res, activo,numero, e = 2.71828;
        String val, operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            escribir("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escribir("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escribir("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escribir("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escribir("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escribir("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escribir("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escribir("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            escribir("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            escribir("0");
        }

        private void btnpuntocoma_Click(object sender, EventArgs e)
        {
            escribir(".");
        }

        private void btnmasomenos_Click(object sender, EventArgs e)
        {
            positivonegativo();
        }

        private void btn2nd_Click(object sender, EventArgs e)
        {
            cambio();
            String texto = "";
            texto = btn2nd.Text;
            if (texto == "2nd")
            {
                btnx2.Text="x2";
                btnraiz.Text="√";
                btnxelevay.Text="x^y";
                btndiezx.Text="10x";
                btnlog.Text="log";
                btnln.Text="in";
            }
            else
            {
                btnx2.Text="x3";
                btnraiz.Text="∛";
                btnxelevay.Text="y√x";
                btndiezx.Text="2x";
                btnlog.Text="log y x";
                btnln.Text="e x";
            }
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            String texto = "";
            texto = btnx2.Text;
            if (texto == "x2")
            {
                pordos();
            }
            else
            {
                portres();
            }
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            String texto = "";
            texto = btnraiz.Text;
            if (texto == "√")
            {
                sqrt();
            }
            else
            {
                cbrt();
            }
        }

        private void btnxelevay_Click(object sender, EventArgs e)
        {
            String texto = "";
            texto = btnxelevay.Text;
            if (texto == "y√x")
            {
                raiz();
            }
            else
            {
                exponente();
            }
        }

        private void btndiezx_Click(object sender, EventArgs e)
        {
            String texto = "";
            texto = (btndiezx.Text);
            if (texto == "10x")
            {
                diezelevado();
            }
            else
            {
                doselevado();
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            numero = double.Parse(txtPantalla.Text);
            String text = "";
            text = btnlog.Text;
            if (text == "log")
            {
                log();
            }
            else
            {
                logloco();
                txtPantalla2.Text=(numero + "log base:");
            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            String text = "";
            text = btnln.Text;
            if (text == "In")
            {
                log();
            }
            else
            {
                ex();
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            Sin();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            Cos();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            Tan();
        }

        private void btndivporuno_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            res = 1 / n1;
            txtPantalla.Text=("" + res);
            txtPantalla2.Text=("1/" + n1 + "=");
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            escribir("3.14159265359");
        }

        private void btne_Click(object sender, EventArgs e)
        {
            euler();
        }

        private void btnequis_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            res = Math.Abs(n1);
            txtPantalla.Text=("" + res);
            txtPantalla2.Text=("abs(" + n1 + ")");
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            activo = 4;
            n1 = double.Parse(txtPantalla.Text);
            txtPantalla2.Text=(n1 + ",e+");
            txtPantalla.Text=("");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            borrarCE();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            activo = 5;
            n1 = double.Parse(txtPantalla.Text);
            txtPantalla2.Text=(n1 + "mod");
            txtPantalla.Text=("");
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operacion("/");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operacion("*");
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operacion("-");
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operacion("+");
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            operar();
        }

        private void btncorchete1_Click(object sender, EventArgs e)
        {
            escribir("(");
        }

        private void btncorchete2_Click(object sender, EventArgs e)
        {
            escribir(")");
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            factorial();
        }
        private void escribir(String n)
        {
            if (!"0".Equals(n))
            {// if (n!="0"
                cont++;
                if (cont == 1)
                {
                    txtPantalla.Text = "";
                    txtPantalla.Text = (n);
                }
                else
                {
                    val = (txtPantalla.Text);
                    val += n;
                    txtPantalla.Text = (val);
                }
            }
            else if (cont > 0)
            {
                val = txtPantalla.Text;
                val += n;
                txtPantalla.Text = (val);

            }
        }
        private void operar()
        {
            if (activo == 0.0)
            {

                n2 = double.Parse(txtPantalla.Text);
                cont = 0;


                switch (operador)
                {
                    case "+":
                        {
                            res = n1 + n2;
                            break;
                        }
                    case "-":
                        {
                            res = n1 - n2;
                            break;
                        }
                    case "*":
                        {
                            res = n1 * n2;
                            break;
                        }
                    case "/":
                        {
                            res = n1 / n2;
                            break;
                        }
                    default:
                        {

                            break;
                        }
                }
                txtPantalla.Text = ("" + res);
            }
            else if (activo == 1.0)
            {

                n1 = double.Parse(txtPantalla.Text);
                if (n1 == 2)
                {
                    numero = numero * numero;
                    txtPantalla.Text=("" + numero);
                    txtPantalla2.Text=(numero + "^" + n1);
                }

                else
                {
                    n2 = n1;
                    numero = numero * numero;
                    n1 = n1 - 2;
                    while (n1 > 0)
                    {
                        numero = numero * n2;
                        n1 = n1 - 1;
                    }
                    txtPantalla.Text=("" + numero);
                    txtPantalla2.Text=(numero + "^" + n1);
                }
            }
            else if (activo == 2.0)
            {
                Double si = 0.0;
                si = double.Parse(txtPantalla.Text);
                res = Math.Pow(si, 1.0 / numero);
                txtPantalla.Text=("" + res);
                txtPantalla2.Text=(numero + "raiz de:" + si + "=");
            }
            else if (activo == 3.0)
            {
                n1 = double.Parse(txtPantalla.Text);
                res = Math.Log(numero) / Math.Log(n1);
                txtPantalla.Text=("" + res);
                txtPantalla2.Text=(numero + "log base:" + n1 + " =");
            }
            else if (activo == 4.0)
            {
                Double diez = 10.0;

                numero = double.Parse(txtPantalla.Text);
                if (numero == 1)
                {
                    res = diez * n1;
                    txtPantalla.Text=("" + res);
                    txtPantalla2.Text=(n1 + ",e+" + numero + " =");
                }
                else
                {
                    n2 = diez;
                    diez = diez * diez;
                    numero = numero - 2;
                    while (numero > 0)
                    {
                        diez = diez * n2;
                        numero = numero - 1;
                    }
                    res = diez * n1;
                    txtPantalla.Text=("" + res);
                    txtPantalla2.Text=(n1 + ",e+" + numero + " =");
                }
            }
            else if (activo == 5.0)
            {
                numero = double.Parse(txtPantalla.Text);
                res = n1 % numero;
                txtPantalla.Text=("" + res);
                txtPantalla2.Text=(n1 + "mod" + numero + " =");

            }

        }
        private void exponente()
        {

            activo = 1.0;
            numero = double.Parse(txtPantalla.Text);
            txtPantalla2.Text=(numero + "^");
            txtPantalla.Text = "";

        }
        private void raiz()
        {
            numero = double.Parse(txtPantalla.Text);
            activo = 2.0;
            //numero es la raiz
            txtPantalla2.Text=(numero+"raiz de:");
            txtPantalla.Text = "";
        }
        private void cambio()
        {
            String texto = "";
            texto = btn2nd.Text;
            if (texto == "2nd")
            {
                btn2nd.Text="1st";
            }
            else
            {
                btn2nd.Text="2nd";
            }
        }
        private void portres()
        {
            double n2 = 0;
            n1 = double.Parse(txtPantalla.Text);
            n2 = n1 * n1;
            res = n1 * n2;
            txtPantalla.Text=("" + res);
        }
        private void pordos()
        {
            n1 = double.Parse(txtPantalla.Text);
            res = n1 * n1;
            txtPantalla.Text=("" + res);
        }
        private void cbrt()
        {
            n1 = double.Parse(txtPantalla.Text);
            res = Math.Pow(n1, 1 / 3);
            txtPantalla.Text=("" + res);
        }
        private void sqrt()
        {
            n1 = double.Parse(txtPantalla.Text);
            res = Math.Sqrt(n1);
            txtPantalla.Text=("" + res);
        }
        private void diezelevado()
        {
            numero = 10;
            n1 = double.Parse(txtPantalla.Text);
            if (n1 == 1)
            {
                txtPantalla.Text=("" + numero);
            }
            else
            {
                n2 = n1;
                numero = numero * numero;
                n1 = n1 - 2;
                while (n1 > 0)
                {
                    numero = numero * 10;
                    n1 = n1 - 1;
                }
                txtPantalla.Text=("" + numero);
            }

        }
        private void doselevado()
        {
            numero = 2;
            n1 = double.Parse(txtPantalla.Text);
            if (n1 == 1)
            {
                txtPantalla.Text=("" + numero);
            }
            else
            {
                n2 = n1;
                numero = numero * numero;
                n1 = n1 - 2;
                while (n1 > 0)
                {
                    numero = numero * 2;
                    n1 = n1 - 1;
                }
                txtPantalla.Text=("" + numero);
            }
        }
        private void log()
        {
            n1 = double.Parse(txtPantalla.Text);
            res = Math.Log(n1);
            txtPantalla.Text=("" + res);
        }
        private void logloco()
        {
            activo = 3;
            txtPantalla.Text=("");
            txtPantalla.Text=("");
        }
        private void ex()
        {

            n1 = double.Parse(txtPantalla.Text);
            if (n1 == 1)
            {
                txtPantalla.Text=("" + e);
            }
            else
            {
                numero = n1;
                e = e * e;
                n1 = n1 - 2;
                while (n1 > 0)
                {
                    e = e * numero;
                    n1 = n1 - 1;
                }
                txtPantalla.Text=("" + e);
            }
        }
        private void Tan()
        {
            n1 = double.Parse(txtPantalla.Text);
            
            res = Math.Tan(n1);
            txtPantalla.Text=("" + res);
        }
        private void Sin()
        {
            n1 = double.Parse(txtPantalla.Text);
            
            res = Math.Sin(n1);
            txtPantalla.Text=("" + res);
        }
        private void Cos()
        {
            n1 = double.Parse(txtPantalla.Text);
            
            res = Math.Cos(n1);
            txtPantalla.Text=("" + res);
        }
        private void euler()
        {
            n1 = double.Parse(txtPantalla.Text);
            double e = 1.0;
            double factorial = 1.0;
            for (int i = 1; i < n1; i++)
            {
                factorial *= i;
                double termino = 1.0 / factorial;
                e += termino;
            }
            txtPantalla.Text=("" + e);
        }
        private void borrarCE()
        {
            n2 = 0;
            txtPantalla.Text=("");
        }
        private void borrar()
        {
            n1 = 0;
            n2 = 0;
            res = 0;
            cont = 0;
            txtPantalla.Text=("0");
        }
        private void factorial()
        {
            n1 = double.Parse(txtPantalla.Text);
            int factorial = 1;
            for (int i = 1; i <= n1; i++)
            {
                factorial *= i;
            }
            txtPantalla.Text=("" + factorial);
        }
        private void positivonegativo()
        {
            n1 = double.Parse(txtPantalla.Text);
            res = n1 * -1;
            txtPantalla.Text=("" + res);
            cont = 0;
        }
        private void operacion(String op)
        {
            operador = op;
            cont = 0;
            n1 = double.Parse(txtPantalla.Text);
        }


    }
}
