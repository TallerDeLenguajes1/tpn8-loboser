using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace App
{
    class Calculadora
    {
        private float numero1;
        private float numero2;
        private string operacion;
        private float resultado;
        private string fecha;
        private string hora;
        private int bandera;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        public int Bandera { get => bandera; set => bandera = value; }

        public float Suma()
        {
            Operacion = "+";
            Resultado = Numero1 + Numero2;
            return Resultado;
        }

        public float Resta()
        {
            Operacion = "-";
            Resultado = Numero1 - Numero2;
            return Resultado;
        }

        public float Multiplicacion()
        {
            Operacion = "*";
            Resultado = Numero1 * Numero2;
            return Resultado;
        }

        public float Division()
        {
            if (Numero2 != 0)
            {
                Operacion = "/";
                Resultado = Numero1 / Numero2;
                return Resultado;
            }
            else
            {
                Bandera = 1;
                return 0;
            }
        }

        public string Op()
        {
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Hora = DateTime.Now.ToString("hh:mm");
            if (bandera == 0)
            {
                Operacion = Fecha + " " + Hora + " --> " + Numero1 + Operacion + Numero2 + "=" + Resultado;
            }
            else
            {
                Operacion = Fecha + " " + Hora + " --> " + Numero1 + Operacion + Numero2 + "=Error";
            }
            return Operacion;
        }
    }
}