using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;

namespace Libreria.entidades
{
    public sealed class ViajeSudamericanos : Viajes
    {
        private ESudamericanos tipoViaje;

        #region constructor
        public ViajeSudamericanos() : base()
        {
            this.tipoViaje = new ESudamericanos();
        }
        public ViajeSudamericanos(ESudamericanos tipoViaje, EEstadoViaje estadoDeViaje, DateTime fechaDeViaje, Embarcos tipoCrucero)
                : base(estadoDeViaje, fechaDeViaje, tipoCrucero)
        {
            this.tipoViaje = tipoViaje;
            this.AsignarTipoDeViaje(this.tipoViaje);
            this.calcularCostoPasajes();
        }
        #endregion

        #region propiedaes
        public ESudamericanos TipoViaje { get => tipoViaje; set => tipoViaje = value; }
        #endregion

        #region sobrescritura

        public override string ToString()
        {
            return $"TIPO DE VIAJE: {this.tipoViaje.ToString()}\n" + base.ToString();
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

        #region sobrecarga de operadores
        public static ViajeSudamericanos operator +(ViajeSudamericanos viajeA, Pasajeros pasajero)
        {
            viajeA = (ViajeSudamericanos)viajeA.AgregarPasajero(viajeA, pasajero);
            return viajeA;
        }

        #endregion

        #region sobrescritura

        /// <summary>
        /// Asigna el tipo de destino: Sudamericano
        /// </summary>
        /// <param name="enviar"></param>
        public override void AsignarTipoDeViaje(Object enviar)
        {
            string dato = enviar.ToString();
            base.destino.EsExtraRegional = false;
            base.AsignarTipoDeViaje(dato);
        }
        #endregion

        #region implementacion del metodo abstracto

        /// <summary>
        /// Calcula el precio del pasaje
        /// ademas se implementan los datos de funcionamiento como 
        /// los viajes programados, la duracion de viaje
        /// </summary>
        protected override void calcularCostoPasajes()
        {
            Random numeroAlatorio = new Random();
            base.duracionDelViaje = numeroAlatorio.Next(72, 360);
            base.fechaDeLlegada = base.fechaDeViaje.AddHours(base.duracionDelViaje);
            base.tipoCrucero.HorasDeViaje += base.duracionDelViaje;

            ViajesProgramados viajesProgramados = new ViajesProgramados(base.Destino.Nombre, base.fechaDeViaje, base.fechaDeLlegada);
            base.tipoCrucero.ListaViajesProgramados.Add(viajesProgramados);

            double costo = 57 * base.duracionDelViaje;
            base.costoViajeTurista = costo;
            base.costoViajePremiun = costo + costo * 0.20;
        }
        #endregion
    }
}
