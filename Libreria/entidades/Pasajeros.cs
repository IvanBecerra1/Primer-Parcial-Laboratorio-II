using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;
namespace Libreria.entidades
{
    public sealed class Pasajeros : Persona
    {
        private ETipoClase tipoClase;
        private Equipaje equipaje;
        private int camaroteAsignado;
        private int cantidadViajesHechos;

        #region constructores
        public Pasajeros()
        {
            TipoClase = new ETipoClase();
        }
        public Pasajeros(ETipoClase tipoclase, Equipaje equipaje, string nombre, string apellido, string dni, string edad, string nacionalidad, Pasaporte pasaporte)
            : base(nombre, apellido, dni, edad, nacionalidad, pasaporte)
        {
            this.tipoClase = tipoclase;
            this.equipaje = equipaje;
        }
        #endregion

        #region propiedaes
        public ETipoClase TipoClase { get => this.tipoClase; set => this.tipoClase = value; }
        public int CamaroteAsignado { get => this.camaroteAsignado; set => this.camaroteAsignado = value; }
        public int CantidadViajesHechos { get => this.cantidadViajesHechos; set => this.cantidadViajesHechos = value; }
        public Equipaje Equipaje { get => equipaje; set => equipaje = value; }

        #endregion

        #region sobrescritura
        public override string ToString()
        {
            return $"{base.nombre} - {this.cantidadViajesHechos}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region metodo de clase
        public static int ordenarPorCantidadDeViajes(Pasajeros pasajeroA, Pasajeros pasajeroB)
        {
            return pasajeroA.cantidadViajesHechos.CompareTo(pasajeroB.cantidadViajesHechos) * -1;
        }
        #endregion

        public static implicit operator string(Pasajeros pasajeros)
        {
            return pasajeros.Nombre;
        }

        public static explicit operator int(Pasajeros pasajeros)
        {
            return int.Parse(pasajeros.Edad);
        }

    }
}
