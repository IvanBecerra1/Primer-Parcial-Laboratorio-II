using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;

namespace Libreria.entidades
{
    public class ViajesExtraRegional : Viajes
    {
        private EExtraRegional tipoViaje;
        
        public ViajesExtraRegional(EExtraRegional tipoViaje, EEstadoViaje estadoDeViaje, DateTime fechaDeViaje, Embarcos tipoCrucero)
                : base(estadoDeViaje, fechaDeViaje, tipoCrucero)
        {
            this.tipoViaje = tipoViaje;
            this.mostrarTipo(this.tipoViaje);
            this.calcularCostoPasajes();
        }
        public EExtraRegional TipoViaje { get => tipoViaje; set => tipoViaje = value; }

        public static ViajesExtraRegional operator +(ViajesExtraRegional viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;
            viajeA = (ViajesExtraRegional)viajeA.AgregarPasajero(viajeA, pasajero);

            return viajeA;
        }

        public override void mostrarTipo(Object enviar)
        {
            string dato = enviar.ToString();
            base.mostrarTipo(dato);
        }

        protected override void calcularCostoPasajes()
        {
            Random numeroAlatorio = new Random();
            base.duracionDelViaje = numeroAlatorio.Next(480, 720);
            base.fechaDeLlegada = base.fechaDeViaje.AddHours( (base.duracionDelViaje) );
            base.tipoCrucero.HorasDeViaje += base.duracionDelViaje;

            ViajesProgramados viajesProgramados = new ViajesProgramados(base.Destino, base.fechaDeViaje, base.fechaDeLlegada);
            base.tipoCrucero.ListaViajesProgramados.Add(viajesProgramados);

            double costo = 120 * base.duracionDelViaje;

            base.costoViajeTurista = costo;
            base.costoViajePremiun = costo + costo * 0.20;


            int cantidadTurista = 1 + Viajes.cantidad(this, ETipoClase.TURISTA);
            int cantidadPremiun = 1 + Viajes.cantidad(this, ETipoClase.PREMIUN);
            Viajes.GananciasRegional += (int)base.costoViajeTurista * cantidadTurista;
            Viajes.GananciasRegional += (int)base.costoViajeTurista * cantidadPremiun;
        }
    }
}
