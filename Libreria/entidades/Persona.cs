using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string edad;
        protected string nacionalidad;
        protected Pasaporte pasaporte;

        #region Constructores
        public Persona()
        {
            pasaporte = new Pasaporte();
        }

        public Persona(string nombre, string apellido, string dni, string edad, string nacionalidad, Pasaporte pasaporte) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
            this.pasaporte = pasaporte;
        }
        #endregion

        #region Props

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public Pasaporte Pasaporte { get => pasaporte; set => pasaporte = value; }

        #endregion

        #region Encapsulamiento
        public override string ToString()
        {
            return $"nombre: {this.Nombre} - apellido {this.apellido} - dni: {this.dni}\nedad {this.edad} - nacionalidad {this.nacionalidad}\n" +
                $"passaporte: {this.pasaporte.ToString()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Persona)
            {
                return (this == ((Persona)obj));
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        #endregion


        public static bool operator ==(Persona personaA, Persona personaB)
        {
            /*Chequear que no sea nulo*/

            return (personaA.dni == personaB.dni);
        }

        public static bool operator !=(Persona personaA, Persona personaB)
        {
            /*Chequear que no sea nulo*/

            return !(personaA == personaB);
        }

        public static bool operator ==(Persona personaA, string dni)
        {
            /*Chequear que no sea nulo*/

            return (personaA.dni == dni);
        }

        public static bool operator !=(Persona personaA, string dni)
        {
            /*Chequear que no sea nulo*/

            return !(personaA == dni);
        }
    }
}
