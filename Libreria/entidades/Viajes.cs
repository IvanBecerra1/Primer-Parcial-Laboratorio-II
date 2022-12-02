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
        protected static int idContador;
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
        protected Destino destino;


        #region constructores
        public Viajes()
        {
            this.id = Viajes.idContador++;
            this.ciudadDePartida = "Buenos Aires";
            this.estadoDelViaje = EEstadoViaje.DISPONIBLE;
            this.listaPasajeros = new List<Pasajeros>();
            this.destino = new Destino();
        }
        public Viajes(Embarcos tipoCrucero, DateTime fechaDeViaje) : this()
        {
            this.tipoCrucero = tipoCrucero;

            Math.Round((tipoCrucero.CantidadCamarotes * 0.35) * 4);
            this.cantCamarotesDisponiblesPremiun = (int)Math.Round((tipoCrucero.CantidadCamarotes * 0.35) * 4);
            this.cantCamarotesDisponiblesTurista = (tipoCrucero.CantidadCamarotes * 4) - this.cantCamarotesDisponiblesPremiun;

            this.cantidadRestantePremiun = cantCamarotesDisponiblesPremiun;
            this.cantidadRestanteTurista = cantCamarotesDisponiblesTurista;
        }
        public Viajes(EEstadoViaje estadoDelViaje, DateTime fechaDeViaje, Embarcos tipoCrucero)
            : this(tipoCrucero, fechaDeViaje)
        {
            this.estadoDelViaje = estadoDelViaje;
            this.fechaDeViaje = fechaDeViaje;
        }

        #endregion

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
        public int Id { get => id; set => id = value; }
        public DateTime FechaDeLlegada { get => fechaDeLlegada; set => fechaDeLlegada = value; }
        public int CantidadRestanteTurista { get => cantidadRestanteTurista; set => cantidadRestanteTurista = value; }
        public int CantidadRestantePremiun { get => cantidadRestantePremiun; set => cantidadRestantePremiun = value; }

        public Destino Destino { get => destino; set => destino = value; }

        #endregion

        #region sobrescritura
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
            return base.GetHashCode();
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
        }

        #endregion

        #region Sobrecarga

        public static bool operator ==(Viajes viajeA, Pasajeros pasajero)
        {
            return viajeA.listaPasajeros.Contains(pasajero);
        }
        public static bool operator !=(Viajes viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;

            return !(viajeA == pasajero);
        }
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

        public static Viajes operator -(Viajes viajeA, Pasajeros pasajero)
        {
            if (viajeA.estadoDelViaje == EEstadoViaje.EN_VIAJE
               || viajeA.estadoDelViaje == EEstadoViaje.NO_DISPONIBLE)
            {
                return viajeA;
            }

            if (!(viajeA == pasajero))
            {
                return viajeA;
            }

            viajeA.listaPasajeros.Remove(pasajero);

            double costo = 0;
            if (pasajero.TipoClase == ETipoClase.TURISTA)
            {
                costo = Viajes.calcularPrecioFinalBoleto(viajeA, true);
                viajeA.CantidadRestanteTurista++;
            }
            else
            {
                costo = Viajes.calcularPrecioFinalBoleto(viajeA, false);
                viajeA.CantidadRestantePremiun++;
            }

            if (!(viajeA.cantidadRestanteTurista == 0 && viajeA.cantidadRestantePremiun == 0) )
            {
                viajeA.EstadoDelViaje = EEstadoViaje.DISPONIBLE;
            }

            viajeA.Destino.TotalFacturacion -= costo;
            viajeA.destino.CantidadConcurrido--;
            viajeA.tipoCrucero.CapacidadBodega += pasajero.Equipaje.PesoValija1;
            viajeA.tipoCrucero.CapacidadBodega += pasajero.Equipaje.PesoValija2;

            return viajeA;
        }
        protected Viajes AgregarPasajero(Viajes viajeA, Pasajeros pasajero)
        {
            if (viajeA.estadoDelViaje == EEstadoViaje.EN_VIAJE
                || viajeA.estadoDelViaje == EEstadoViaje.LLENO
                || viajeA.estadoDelViaje == EEstadoViaje.NO_DISPONIBLE)
            {
                return viajeA;
            }
            if ((viajeA == pasajero))
            {
                return viajeA;
            }
            if ((pasajero.TipoClase == ETipoClase.TURISTA && viajeA.CantidadRestanteTurista == 0)
                || (pasajero.TipoClase == ETipoClase.PREMIUN && viajeA.CantidadRestantePremiun == 0))
            {
                return viajeA;
            }
            if (viajeA.tipoCrucero.CapacidadBodega <= 0)
            {
                viajeA.tipoCrucero.CapacidadBodega = 0;
                return viajeA;
            }

            int camaroteAsignado = 0;
            double costo = 0;

            if (pasajero.TipoClase == ETipoClase.TURISTA)
            {
                costo = Viajes.calcularPrecioFinalBoleto(viajeA, true); 
                camaroteAsignado = cantidad(viajeA.ListaPasajeros, ETipoClase.TURISTA);
                viajeA.cantidadRestanteTurista--;
            }
            else if (pasajero.TipoClase == ETipoClase.PREMIUN)
            {
                costo = Viajes.calcularPrecioFinalBoleto(viajeA, false);
                camaroteAsignado = cantidad(viajeA.ListaPasajeros, ETipoClase.PREMIUN); 
                viajeA.cantidadRestantePremiun--;
            }

            pasajero.CamaroteAsignado = camaroteAsignado;
            pasajero.CantidadViajesHechos++;

            viajeA.tipoCrucero.CapacidadBodega -= pasajero.Equipaje.PesoValija1;
            viajeA.tipoCrucero.CapacidadBodega -= pasajero.Equipaje.PesoValija2;

            viajeA.Destino.TotalFacturacion += costo;
            viajeA.destino.CantidadConcurrido++;
            viajeA.listaPasajeros.Add(pasajero);

            if (viajeA.cantidadRestanteTurista == 0 && viajeA.cantidadRestantePremiun == 0)
            {
                viajeA.EstadoDelViaje = EEstadoViaje.LLENO;
            }
            
            return viajeA;
        }
        #endregion

        #region metodo virtual
        /// <summary>
        /// Este metodo funciona para asignar el nombre 
        /// al destino del viaje.
        /// </summary>
        /// <param name="enviar"></param>
        public virtual void AsignarTipoDeViaje(Object enviar)
        {
            this.Destino.Nombre = enviar.ToString();
        }
        #endregion

        #region metodo abstracto

        /// <summary>
        /// Este metodo abstracto sirvira para calcular los costos de
        /// los pasasjes entre los viajes Extra regional y sudamericano
        /// tendra su implementacion en la clases derivadas.
        /// </summary>
        protected abstract void calcularCostoPasajes();
        #endregion

        #region metodos de clase

        /// <summary>
        /// Retornara la cantidad de pasajeros que estan dentro de la lista
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="tipo"></param>
        /// <returns>El numero de pasajeros Turista o Premiun</returns>
        protected static int cantidad(List<Pasajeros> listaPasajeros, ETipoClase tipo)
        {
            List<Pasajeros> pasajerosEncontrados = new List<Pasajeros>();
            pasajerosEncontrados = listaPasajeros.FindAll(aux => aux.TipoClase == tipo);
            return pasajerosEncontrados.Count;
        }
      
        /// <summary>
        /// Calcula el boleto para el pasajero, incluyendo 
        /// los impuestos y tasas
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="turista"></param>
        /// <returns>Devolvera el precio final del boleto</returns>
        public static double calcularPrecioFinalBoleto(Viajes viaje, bool turista)
        {
            double costo = 0;

            if (turista)
                costo = viaje.costoViajeTurista;
            else
                costo = viaje.costoViajePremiun;

            const double IVA = 0.21;
            const double TASAS = 0.5;
            const double IMPUESTO_PAIS = 0.30;

            double costoImpuestos = ((costo) * IVA) + ((costo) * TASAS) + ((costo) * IMPUESTO_PAIS);
            double costoFinal = costo + costoImpuestos;
            return costoFinal;
        }
        #endregion
    }
}
