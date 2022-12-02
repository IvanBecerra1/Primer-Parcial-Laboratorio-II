using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class Destino
    {
        private string nombre;
        private bool esExtraRegional;
        private int cantidadConcurrido;
        private double totalFacturacion;

        #region constructor
        public Destino()
        {
            this.nombre = "";
            this.cantidadConcurrido = 0;
            this.totalFacturacion = 0;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int CantidadConcurrido { get => this.cantidadConcurrido; set => this.cantidadConcurrido = value; }
        public double TotalFacturacion { get => Math.Round(totalFacturacion); set => this.totalFacturacion = value; }
        public bool EsExtraRegional { get => this.esExtraRegional; set => this.esExtraRegional = value; }
        #endregion

        #region sobrescritura
        public override bool Equals(object obj)
        {
            if (obj is Destino)
            {
                return (this == ((Destino)obj));
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{this.nombre} - {this.totalFacturacion} - {this.esExtraRegional} - {this.cantidadConcurrido}";
        }
        #endregion

        #region sobrecarga de operadores
        public static explicit operator string(Destino destinoA)
        {
            return destinoA.nombre;
        }
        public static bool operator ==(Destino destinoA, Destino destinoB)
        {
            return (destinoA.nombre == destinoB.nombre);
        }
        public static bool operator !=(Destino destinoA, Destino destinoB)
        {
            return !(destinoA == destinoB);
        }
        public static int OrdenarPorDestinoPedido(Destino destinoA, Destino destinoB)
        {
            return (destinoA.cantidadConcurrido.CompareTo(destinoB.cantidadConcurrido)) * -1;
        }
        #endregion
    }
}
