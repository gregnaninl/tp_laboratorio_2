using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClculadora
{
    class Numero
    {

        private double numero;

        
        /// <summary>
        /// constructor por defecto el inicializará el
        /// atributo numero en  0 
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor recibirá un double y cargará en número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor recibirá un String que validará 
        /// y cargará en número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            SetNumero(numero);
        }
                
        /// <summary>
        /// retorna al valor del atributo numero
        /// </summary>
        /// <returns></returns>
        public double GetNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// valida que sea un double valido y lo retorna o en 
        /// caso contrario retorna 0
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private double ValidarNumero(string numero)
        {
            double aux;
            if (double.TryParse(numero, out aux))
            {
                return aux;
            }
            else
            {
                return aux = 0;
            }
        }

        /// <summary>
        /// carga el valor validado en el atriuto numero
        /// </summary>
        /// <param name="numero"></param>
        private void SetNumero( string numero)
        {
            this.numero = ValidarNumero(numero);
        }
    }
}
