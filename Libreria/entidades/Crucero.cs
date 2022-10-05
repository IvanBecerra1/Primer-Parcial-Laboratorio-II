using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Libreria.entidades
{
    public class Embarcos
    {
        protected bool disponible;
        protected string matricula; // alfanumerico de 8 digitos
        protected string nombre;

        protected int cantidadCamarotes;
        protected int cantidadSalones;
        protected List<Esalones> listaSalones;
        protected List<ViajesProgramados> listaViajesProgramados;

        protected double capacidadBodega;
        protected bool casino;
        protected List<DateTime> fechasProgramadas;

        private double horasDeViaje;

        public Embarcos()
        {
            this.listaViajesProgramados = new List<ViajesProgramados>();
            this.fechasProgramadas = new List<DateTime>();
            this.listaSalones = new List<Esalones>();            
            this.matricula = Embarcos.generarMatricula();

            disponible = true;
            this.listaSalones.Add(Esalones.Comedor);
        }
        public Embarcos(string nombre, int cantidadCamarotes, int cantidadSalones, double capacidadBodega, bool casino) : this()
        {
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadSalones = cantidadSalones;
            this.capacidadBodega = capacidadBodega;
            this.casino = casino;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CantidadCamarotes
        {
            get { return cantidadCamarotes; }
            set { cantidadCamarotes = value; }
        }

        public int CantidadSalones
        {
            get { return cantidadSalones; }
            set { cantidadSalones = value; }
        }

        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }

        public override string ToString()
        {
            return $"Matricula {this.matricula} - {this.nombre} - Duracion acumulada: {this.HorasDeViaje}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Embarcos)
            {
                return (this == ((Embarcos) obj));
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

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

        public List<Esalones> ListaSalones { get => listaSalones; set => listaSalones = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public double CapacidadBodega1 { get => capacidadBodega; set => capacidadBodega = value; }
        public List<DateTime> FechasProgramadas { get => fechasProgramadas; set => fechasProgramadas = value; }
        public List<ViajesProgramados> ListaViajesProgramados { get => listaViajesProgramados; set => listaViajesProgramados = value; }
        public bool Casino { get => casino; set => casino = value; }
        public double HorasDeViaje { get => horasDeViaje; set => horasDeViaje = value; }

        private static string generarMatricula()
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
    }
}
