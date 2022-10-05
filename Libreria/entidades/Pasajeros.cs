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
        
        public Pasajeros()
        {
            TipoClase = new ETipoClase();
        }
        public Pasajeros(ETipoClase tipoclase, Equipaje equipaje, string nombre, string apellido, string dni, string edad, string nacionalidad, Pasaporte pasaporte)
            : base(nombre,apellido,dni,edad,nacionalidad, pasaporte)
        {
            this.tipoClase = tipoclase;
            this.equipaje = equipaje;
        }
        public ETipoClase TipoClase { get => tipoClase; set => tipoClase = value; }
        public int CamaroteAsignado { get => camaroteAsignado; set => camaroteAsignado = value; }
        public int CantidadViajesHechos { get => cantidadViajesHechos; set => cantidadViajesHechos = value; }
        public Equipaje Equipaje { get => equipaje; set => equipaje = value; }

        public override string ToString()
        {
            return $"{base.nombre} - {this.cantidadViajesHechos}"; 
        }
    }
}
