using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;

namespace Libreria.entidades
{
    public sealed class ViajesExtraRegional : Viajes
    {
        private EExtraRegional tipoViaje;

        #region constructores
        public ViajesExtraRegional(EExtraRegional tipoViaje, EEstadoViaje estadoDeViaje, DateTime fechaDeViaje, Embarcos tipoCrucero)
              : base(estadoDeViaje, fechaDeViaje, tipoCrucero)
        {
            this.tipoViaje = tipoViaje;
            this.AsignarTipoDeViaje(this.tipoViaje);
            this.calcularCostoPasajes();

        }
        #endregion

        #region propiedades
        public EExtraRegional TipoViaje { get => tipoViaje; set => tipoViaje = value; }

        #endregion

        #region sobrecarga de operadores
        public static ViajesExtraRegional operator +(ViajesExtraRegional viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;
            viajeA = (ViajesExtraRegional)viajeA.AgregarPasajero(viajeA, pasajero);

            return viajeA;
        }
        #endregion

        #region sobrescritura

        /// <summary>
        /// Asigna el tipo de destino
        /// </summary>
        /// <param name="enviar"></param>
        public override void AsignarTipoDeViaje(Object enviar)
        {
            string dato = enviar.ToString();
            base.destino.EsExtraRegional = true;
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
            base.duracionDelViaje = numeroAlatorio.Next(480, 720);
            base.fechaDeLlegada = base.fechaDeViaje.AddHours((base.duracionDelViaje));
            base.tipoCrucero.HorasDeViaje += base.duracionDelViaje;

            ViajesProgramados viajesProgramados = new ViajesProgramados(base.Destino.Nombre, base.fechaDeViaje, base.fechaDeLlegada);
            base.tipoCrucero.ListaViajesProgramados.Add(viajesProgramados);

            double costo = 120 * base.duracionDelViaje;

            base.costoViajeTurista = costo;
            base.costoViajePremiun = costo + costo * 0.20;
        }
        #endregion

    }
}
