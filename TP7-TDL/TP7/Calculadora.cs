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

        public float Suma()
        {
            return Numero1f + Numero2f;
        }

        public float Resta()
        {
            return Numero1f - Numero2f;
        }

        public float Multiplicacion()
        {
            return Numero1f * Numero2f;
        }

        public float Division()
        {
            if (Numero2f != 0.0f)
            {
                return Numero1f / Numero2f;
            }
            else
            {
                Console.WriteLine("Error. El divisor debe ser mayor a 0\n");
            }
            
        }
    }
}
