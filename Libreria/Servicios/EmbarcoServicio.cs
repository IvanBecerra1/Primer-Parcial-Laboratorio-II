using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    /// <summary>
    /// Esta clase solo esta destinada para 
    /// colocar logica de la entidad, para tratar de dejar
    /// a la entidad principal lo mas limpia posible.
    /// </summary>
    public partial class Embarcos
    {
        #region sobrecarga de operadores

        public static bool operator ==(Embarcos cruceroA, string nombre)
        {
            return (cruceroA.nombre == nombre);
        }

        public static bool operator !=(Embarcos cruceroA, string nombre)
        {
            return (cruceroA.nombre == nombre);
        }

        public static bool operator ==(Embarcos cruceroA, Embarcos cruceroB)
        {
            if (cruceroA is null || cruceroB is null)
            {
                return false;
            }

            return (cruceroA.matricula == cruceroB.matricula);
        }

        public static bool operator !=(Embarcos cruceroA, Embarcos cruceroB)
        {
            return !(cruceroA == cruceroB);
        }
        #endregion

        #region metodos de clase

        /// <summary>
        /// Genera una matricula con letras de a-z y numeros 1-9
        /// </summary>
        /// <returns>string</returns>
        private static string GenerarMatricula()
        {

            string letras = "abcdefghijklnñopqmrwz";
            string numeros = "123456789";
            string combinaciones = letras + letras.ToUpper();
            string matricula = "";

            Random rand = new Random();

            do
            {
                char caracter = combinaciones[rand.Next(0, combinaciones.Length)];
                char caracterNum = numeros[rand.Next(0, numeros.Length)];
                matricula += string.Concat(caracter, caracterNum);

            } while (matricula.Length < 8);

            return matricula;
        }
        #endregion
    }
}
