using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        List<Calculadora> Lista;
        Calculadora Calculo;
        string Operacion;
        int selected;
        int bandera = 0;
        int resetear = 0;
        int aux = 0;
        float numero1;
        float numero2;
        public Form1()
        {
            InitializeComponent();
            Calculo = new Calculadora();
            Lista = new List<Calculadora>();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "0"; resetear = 0;}
            else calculo.Text = calculo.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "1"; resetear = 0;}
            else calculo.Text = calculo.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "2"; resetear = 0;}
            else calculo.Text = calculo.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "3"; resetear = 0;}
            else calculo.Text = calculo.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) { calculo.Text = "4"; resetear = 0;}
            else calculo.Text = calculo.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "5"; resetear = 0;}
            else calculo.Text = calculo.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "6"; resetear = 0;}

            else calculo.Text = calculo.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "7"; resetear = 0;}
            else calculo.Text = calculo.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "8"; resetear = 0;}
            else calculo.Text = calculo.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calculo.Text == "Error" || resetear == 1) {calculo.Text = "9"; resetear = 0;}
            else calculo.Text = calculo.Text + "9";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            if (bandera == 0 && calculo.Text != "" && !(calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/")))
            {
                calculo.Text = calculo.Text + ",";
                bandera = 1;
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            if (calculo.Text != "")
            {
                if (calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/"))
                {
                    calculo.Text = calculo.Text.Remove(calculo.Text.Length - 1);
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "+";
                }
                else if (!(calculo.Text.Contains("+") || calculo.Text.Contains("-") || calculo.Text.Contains("*") || calculo.Text.Contains("/")))
                {
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "+";
                }
                bandera = 0;
                aux = calculo.Text.Length;
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if(calculo.Text != "")
            {
                if (calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/"))
                {
                    calculo.Text = calculo.Text.Remove(calculo.Text.Length - 1);
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "-";
                }
                else if (!(calculo.Text.Contains("+") || calculo.Text.Contains("-") || calculo.Text.Contains("*") || calculo.Text.Contains("/")))
                {
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "-";
                }
                bandera = 0;
                aux = calculo.Text.Length;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (calculo.Text != "")
            {
                if (calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/"))
                {
                    calculo.Text = calculo.Text.Remove(calculo.Text.Length - 1);
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "*";
                }
                else if (!(calculo.Text.Contains("+") || calculo.Text.Contains("-") || calculo.Text.Contains("*") || calculo.Text.Contains("/")))
                {
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "*";
                }
                bandera = 0;
                aux = calculo.Text.Length;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (calculo.Text != "")
            {
                if (calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/"))
                {
                    calculo.Text = calculo.Text.Remove(calculo.Text.Length - 1);
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "/";
                }
                else if (!(calculo.Text.Contains("+") || calculo.Text.Contains("-") || calculo.Text.Contains("*") || calculo.Text.Contains("/")))
                {
                    numero1 = Convert.ToSingle(calculo.Text);
                    calculo.Text = calculo.Text + "/";
                }
                bandera = 0;
                aux = calculo.Text.Length;
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (calculo.Text.Contains("+") || calculo.Text.Contains("-") || calculo.Text.Contains("*") || calculo.Text.Contains("/"))
            {
                if (calculo.Text != "" && !(calculo.Text.EndsWith("+") || calculo.Text.EndsWith("-") || calculo.Text.EndsWith("*") || calculo.Text.EndsWith("/")))
                {
                    numero2 = Convert.ToSingle(calculo.Text.Remove(0, aux));

                    Calculo.Numero1 = numero1;
                    Calculo.Numero2 = numero2;

                    if (calculo.Text.Contains("+"))
                    {
                        calculo.Text = Convert.ToString(Calculo.Suma());
                        Operacion = Calculo.Op();
                    }

                    if (calculo.Text.Contains("-"))
                    {
                        calculo.Text = Convert.ToString(Calculo.Resta());
                        Operacion = Calculo.Op();
                    }

                    if (calculo.Text.Contains("*"))
                    {
                        calculo.Text = Convert.ToString(Calculo.Multiplicacion());
                        Operacion = Calculo.Op();
                    }

                    if (calculo.Text.Contains("/"))
                    {
                        Calculo.Division();
                        if (Calculo.Bandera != 1)
                        {
                            calculo.Text = Convert.ToString(Calculo.Division());
                        }
                        else
                        {
                            calculo.Text = "Error";
                        }
                        Operacion = Calculo.Op();
                    }
                    resetear = 1;
                    lista.Items.Add(Operacion);
                    Lista.Add(Calculo);
                }
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            calculo.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case ",":
                    coma.PerformClick();
                    break;
                case "ENTER":
                    igual.PerformClick();
                    break;
                case "+":
                    suma.PerformClick();
                    break;
                case "-":
                    resta.PerformClick();
                    break;
                case "*":
                    multi.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "DELETE":
                    borrar.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                selected = lista.SelectedIndex;
            }
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            if (selected != -1)
            {
                lista.Items.RemoveAt(selected);
                Lista.RemoveAt(selected);
                selected = -1;
            }
        }
    }
}
