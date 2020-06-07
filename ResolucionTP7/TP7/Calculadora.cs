using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Calculadora
    {
        private float numero1f, numero2f;

        public float Numero1f { get => numero1f; set => numero1f = value; }
        public float Numero2f { get => numero2f; set => numero2f = value; }

        public Calculadora()
        {
            numero1f = 0;
            numero2f = 0;
        }
        public Calculadora(float num1f, float num2f)
        {
            numero1f = num1f;
            numero2f = num2f;
        }

        public float Suma()
        {
            return numero1f + numero2f;
        }

        public float Resta()
        {
            return numero1f - numero2f;
        }

        public float Multiplicacion()
        {
            return numero1f * numero2f;
        }

        public float Division()
        {
            return numero1f / numero2f;       
        }
    }
}
