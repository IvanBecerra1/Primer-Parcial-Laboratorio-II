using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;

namespace Libreria.entidades
{
    public abstract class Viajes
    {
        protected int id;
        private static int idContador;

        protected EEstadoViaje estadoDelViaje;

        protected string ciudadDePartida;
        protected DateTime fechaDeViaje;
        protected DateTime fechaDeLlegada;

        protected int cantCamarotesDisponiblesPremiun;
        protected int cantCamarotesDisponiblesTurista;

        protected int cantidadRestanteTurista;
        protected int cantidadRestantePremiun;

        protected List<Pasajeros> listaPasajeros;

        protected Embarcos tipoCrucero;

        protected double costoViajePremiun;
        protected double costoViajeTurista;
        protected double duracionDelViaje;
        protected string destino;

        protected static int gananciasRegional;
        protected static int gananciasSudamericanos;
        
        public Viajes(Embarcos tipoCrucero, DateTime fechaDeViaje)
        {
            this.id = Viajes.idContador++;
            this.tipoCrucero = tipoCrucero;
            this.ciudadDePartida = "Buenos Aires";
            this.estadoDelViaje = EEstadoViaje.DISPONIBLE;
            this.listaPasajeros = new List<Pasajeros>();
            this.tipoCrucero.FechasProgramadas.Add(fechaDeViaje);


            // Obtenemos y seteamos los camarotes
            this.cantCamarotesDisponiblesPremiun = ((int)(tipoCrucero.CantidadCamarotes * 0.35))*4;
            this.cantCamarotesDisponiblesTurista = ((int)(tipoCrucero.CantidadCamarotes - tipoCrucero.CantidadCamarotes * 0.35))*4;
          
            this.cantidadRestantePremiun = cantCamarotesDisponiblesPremiun;
            this.cantidadRestanteTurista = cantCamarotesDisponiblesTurista;
        }
        public Viajes(EEstadoViaje estadoDelViaje, DateTime fechaDeViaje, Embarcos tipoCrucero) 
            : this(tipoCrucero, fechaDeViaje)
        {
            this.estadoDelViaje = estadoDelViaje;
            this.fechaDeViaje = fechaDeViaje;
        }

        #region Propiedades

        public List<Pasajeros> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public int CantCamarotesDisponiblesPremiun { get => cantCamarotesDisponiblesPremiun; set => cantCamarotesDisponiblesPremiun = value; }
        public int CantCamarotesDisponiblesTurista { get => cantCamarotesDisponiblesTurista; set => cantCamarotesDisponiblesTurista = value; }
        public Embarcos TipoCrucero { get => tipoCrucero; set => tipoCrucero = value; }
        public DateTime FechaDeViaje { get => fechaDeViaje; set => fechaDeViaje = value; }
        public EEstadoViaje EstadoDelViaje { get => estadoDelViaje; set => estadoDelViaje = value; }
        public string CiudadDePartida { get => ciudadDePartida; set => ciudadDePartida = value; }
        public double CostoViajePremiun { get => costoViajePremiun; set => costoViajePremiun = value; }
        public double CostoViajeTurista { get => costoViajeTurista; set => costoViajeTurista = value; }
        public double DuracionDelViaje { get => duracionDelViaje; set => duracionDelViaje = value; }
        public string Destino { get => destino; set => destino = value; }
        public int Id { get => id; set => id = value; }
        public DateTime FechaDeLlegada { get => fechaDeLlegada; set => fechaDeLlegada = value; }
        public int CantidadRestanteTurista { get => cantidadRestanteTurista; set => cantidadRestanteTurista = value; }
        public int CantidadRestantePremiun { get => cantidadRestantePremiun; set => cantidadRestantePremiun = value; }
        public static int GananciasRegional { get => gananciasRegional; set => gananciasRegional = value; }
        public static int GananciasSudamericanos { get => gananciasSudamericanos; set => gananciasSudamericanos = value; }

        #endregion

        #region Encapsulamiento
        public override bool Equals(object obj)
        {
            if (obj is Viajes)
            {
                return (this == ((Viajes)obj));
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public virtual void mostrarTipo(Object enviar)
        {
            this.destino = enviar.ToString();
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"Barco: {tipoCrucero.ToString()}");
            foreach (Pasajeros aux in this.listaPasajeros)
            {
                text.AppendLine($"* {aux.Nombre}");
            }

            Console.WriteLine("Pasajeros: ");
            Console.WriteLine(text.ToString());

            return $"Estado: {this.estadoDelViaje} - Partida: {this.ciudadDePartida} - Fecha de Viaje {this.fechaDeViaje}\n" +
                $"Camarotes Premiun {this.cantCamarotesDisponiblesPremiun} - Camarotes Turiste {this.cantCamarotesDisponiblesTurista}";
            //    $"\nDuracion del viaje HS: {Viajes.duracionDelViaje}" +
            //    $"\nCosto Turista: {Viajes.costoViajeTurista} - Costo Premiun: {Viajes.costoViajePremiun}\n";
        }

        #endregion

        #region SobreEscritura
        /**
         * Operador para verificar si un pasajero existe dentro de una lista de viaje, evitamos
         * la repeticion de pasajero.
         * */


        public static bool operator ==(Viajes viajeA, String destino)
        {
            return viajeA.destino == destino;
        }

        public static bool operator !=(Viajes viajeA, String destino)
        {
            return viajeA.destino == destino;
        }


        public static bool operator ==(Viajes viajeA, Pasajeros pasajero)
        {
            return viajeA.listaPasajeros.Contains(pasajero);
        }

        public static bool operator !=(Viajes viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;

            return !(viajeA == pasajero);
        }

        // Evitar viajes repetidos con el mismo crucero.
        public static bool operator ==(Viajes viajeA, Viajes viajeB)
        {
            return (viajeA.tipoCrucero == viajeB.tipoCrucero) && (viajeA.fechaDeViaje == viajeB.fechaDeViaje);
        }
        public static bool operator !=(Viajes viajeA, Viajes viajeB)
        {
            return viajeA == viajeB;
        }
        public static Viajes operator +(Viajes viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;
            viajeA = viajeA.AgregarPasajero(viajeA, pasajero);

            return viajeA;
        }

        protected Viajes AgregarPasajero(Viajes viajeA, Pasajeros pasajero)
        {
            // Spaggeti.com
            if ((viajeA == pasajero) == false)
            {
                if (pasajero.TipoClase == ETipoClase.TURISTA)
                {
                    int camarotesRegistradosTurista = cantidad(viajeA, ETipoClase.TURISTA);
                    if (camarotesRegistradosTurista < viajeA.cantCamarotesDisponiblesTurista)
                    {
                        viajeA.cantidadRestanteTurista--;
                        pasajero.CantidadViajesHechos++;
                        pasajero.CamaroteAsignado = camarotesRegistradosTurista;

                        viajeA.listaPasajeros.Add(pasajero);
                        Console.WriteLine("se agrego al pasajero turista");
                    }
                    else
                    {
                        Console.WriteLine("Camarote Turista Lleno");

                    }
                }
                else if (pasajero.TipoClase == ETipoClase.PREMIUN)
                {
                    int camarotesRegistradosPremiun = cantidad(viajeA, ETipoClase.PREMIUN);
                    if (camarotesRegistradosPremiun < viajeA.cantCamarotesDisponiblesTurista)
                    {
                        viajeA.cantidadRestantePremiun--;
                        pasajero.CantidadViajesHechos++;
                        pasajero.CamaroteAsignado = camarotesRegistradosPremiun;

                        viajeA.listaPasajeros.Add(pasajero);
                        Console.WriteLine("se agrego al pasajero premiun");
                    }
                    else
                    {
                        Console.WriteLine("Camarote Premiun Lleno");
                    }
                }
            }
            else
            {
                Console.WriteLine("YA SE ENCUENTRA DENTRO DEL VIAJE");
            }

            if (viajeA.cantidadRestanteTurista == 0 && viajeA.cantidadRestantePremiun == 0)
            {
                viajeA.EstadoDelViaje = EEstadoViaje.LLENO;
            }
            return viajeA;
        }
        #endregion

        protected abstract void calcularCostoPasajes();

        protected static int cantidad(Viajes viaje, ETipoClase tipo)
        {
            int cantidadDisponible = 0;

            foreach (Pasajeros auxPasajeros in viaje.listaPasajeros)
            {
                if (auxPasajeros.TipoClase == tipo)
                {
                    cantidadDisponible++;
                }
            }

            return cantidadDisponible;
        }
    }
}
