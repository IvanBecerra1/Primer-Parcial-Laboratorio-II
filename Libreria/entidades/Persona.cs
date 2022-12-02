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

        #region propiedades

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public string Dni { get => this.dni; set => this.dni = value; }
        public string Edad { get => this.edad; set => this.edad = value; }
        public string Nacionalidad { get => this.nacionalidad; set => this.nacionalidad = value; }
        public Pasaporte Pasaporte { get => this.pasaporte; set => this.pasaporte = value; }

        #endregion

        #region sobrescritura
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

        #region sobrecarga de operadores


        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return (personaA.dni == personaB.dni) || (personaA.pasaporte.Indentificador == personaB.pasaporte.Indentificador);
        }

        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }

        public static bool operator ==(Persona personaA, string dni)
        {
            return (personaA.dni == dni);
        }

        public static bool operator !=(Persona personaA, string dni)
        {
            return !(personaA == dni);
        }
        #endregion
    }
}
