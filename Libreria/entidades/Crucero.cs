using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Libreria.entidades
{
    public sealed partial class Embarcos
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private int cantidadSalones;
        private double capacidadBodega;
        private double horasDeViaje;
        private bool casino;
        private List<Esalones> listaSalones;
        private List<ViajesProgramados> listaViajesProgramados;

        #region constructores
        public Embarcos()
        {
            this.listaViajesProgramados = new List<ViajesProgramados>();
            this.listaSalones = new List<Esalones>();

            this.matricula = Embarcos.GenerarMatricula();
            this.listaSalones.Add(Esalones.Comedor);
        }
        public Embarcos(string nombre, int cantidadCamarotes, int cantidadSalones, double capacidadBodega, bool casino) 
            : this()
        {
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadSalones = cantidadSalones;
            this.capacidadBodega = capacidadBodega;
            this.casino = casino;
        }

        #endregion

        #region Propiedades
        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int CantidadCamarotes
        {
            get { return this.cantidadCamarotes; }
            set { this.cantidadCamarotes = value; }
        }

        public int CantidadSalones
        {
            get { return this.cantidadSalones; }
            set { this.cantidadSalones = value; }
        }

        public double CapacidadBodega
        {
            get { return this.capacidadBodega; }
            set { this.capacidadBodega = value; }
        }

        public List<Esalones> ListaSalones
        {
            get => this.listaSalones;
            set => this.listaSalones = value;
        }
        public double CapacidadBodega1
        {
            get => this.capacidadBodega;
            set => this.capacidadBodega = value;
        }

        public List<ViajesProgramados> ListaViajesProgramados
        {
            get => this.listaViajesProgramados;
            set => this.listaViajesProgramados = value;
        }
        public bool Casino
        {
            get => this.casino;
            set => this.casino = value;
        }
        public double HorasDeViaje
        {
            get => this.horasDeViaje;
            set => this.horasDeViaje = value;
        }
        #endregion

        #region Sobrescritura
        public override string ToString()
        {
            return $"Matricula {this.matricula} - {this.nombre} - Duracion acumulada: {this.HorasDeViaje}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Embarcos)
            {
                return (this == ((Embarcos)obj));
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
