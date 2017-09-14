using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClculadora
{
    class Calculadora
    {

        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1.GetNumero() + numero2.GetNumero();
                    break;
                case "-":
                    resultado = numero1.GetNumero() - numero2.GetNumero();
                    break;
                case "*":
                    resultado = numero1.GetNumero() * numero2.GetNumero();
                    break;
                case "/":
                    if (numero2.GetNumero() == 0)
                    {
                        resultado = 0;
                    }
                    else
                    {
                        resultado = numero1.GetNumero() / numero2.GetNumero();
                    }
                    break;
                default:
                   
                    break;
            }

            return resultado;        
        }

        /// <summary>
        /// recibe un strig y valida que sea un operador valido
        /// de lo contrario retona un +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            string aux;

            switch (operador)
            {
                case "+":
                    aux = "+";
                    break;
                case "-":
                    aux = "-";
                    break;
                case "*":
                    aux = "*";
                    break;
                case "/":
                    aux = "/";
                    break;
                default:
                    aux = "+";
                    break;
            }
            return aux;
        }

    }
}
