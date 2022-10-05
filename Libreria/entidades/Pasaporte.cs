using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class Pasaporte
    {
        private string indentificador;
        private string lugarNacimiento;
        private string fechaNacimiento;
        private int cantidadDeViajes;

        private DateTime fechaVencimiento;
        private DateTime fechaDeAlta;

        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime FechaDeAlta { get => fechaDeAlta; set => fechaDeAlta = value; }
        public string Indentificador { get => indentificador; set => indentificador = value; }

        public Pasaporte()
        {
            this.indentificador = Pasaporte.generarIndentificador();
        }
        public Pasaporte(string lugarNacimiento, string fechaNacimiento, int cantidadDeViajes, DateTime fechaVencimiento, DateTime fechaDeAlta)
        {
            this.lugarNacimiento = lugarNacimiento;
            this.fechaNacimiento = fechaNacimiento;
            this.cantidadDeViajes = cantidadDeViajes;
            this.fechaVencimiento = fechaVencimiento;
            this.fechaDeAlta = fechaDeAlta;
        }

        public Pasaporte(string indentificador, DateTime fechaVencimiento, DateTime fechaDeAlta)
        {
            this.indentificador = indentificador;
            this.fechaVencimiento = fechaVencimiento;
            this.fechaDeAlta = fechaDeAlta;
        }

        public override string ToString()
        {
            return $"numeroPasaporte: {this.indentificador} - lugar Nacimiento: {this.lugarNacimiento} - fechaNacimiento {this.fechaNacimiento} - cantidad Viaje {this.cantidadDeViajes}\n"
                + $"fecha de vencimiento: {this.fechaVencimiento} fecha de alta {this.fechaDeAlta}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pasaporte)
            {
                return (this == (Pasaporte) obj);
            }
            else 
                return false;
        }
        public static bool operator ==(Pasaporte pasaporteA, Pasaporte pasaporteB)
        {
            return (pasaporteA.indentificador == pasaporteB.indentificador);
        }

        public static bool operator !=(Pasaporte pasaporteA, Pasaporte pasaporteB)
        {
            return (pasaporteA == pasaporteB);
        }



        // 3 letras y seis dígitos

        private static string generarIndentificador()
        {
            string letras = "abcdefghijklnñopqmrwz";
            string numeros = "0123456789";
            string combinaciones = letras + letras.ToUpper();
            string matricula = "";
            int maximoLetras = 0;
            Random rand = new Random();

            do
            {
                if (maximoLetras < 3)
                {
                    char caracter = combinaciones[rand.Next(0, combinaciones.Length)];
                    matricula += caracter;
                    maximoLetras++;
                }

                char caracterNum = numeros[rand.Next(0, numeros.Length)];
                matricula += caracterNum;

            } while (matricula.Length < 9);

            return matricula;
        }
    }
}
