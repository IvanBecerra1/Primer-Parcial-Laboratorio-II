using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Enumeradores;

namespace Libreria.entidades
{
    public class ViajeSudamericanos : Viajes
    {
        private ESudamericanos tipoViaje;

        public ViajeSudamericanos(ESudamericanos tipoViaje,EEstadoViaje estadoDeViaje, DateTime fechaDeViaje, Embarcos tipoCrucero)
                : base(estadoDeViaje, fechaDeViaje, tipoCrucero)
        {
            this.tipoViaje = tipoViaje;
            this.mostrarTipo(this.tipoViaje);
            this.calcularCostoPasajes();
        }

        public ESudamericanos TipoViaje { get => tipoViaje; set => tipoViaje = value; }

        public override string ToString()
        {
            return $"TIPO DE VIAJE: {this.tipoViaje.ToString()}\n" + base.ToString();
        }

        public override void mostrarTipo(Object enviar)
        {
            string dato = enviar.ToString();
            base.mostrarTipo(dato);
        }
        public static ViajeSudamericanos operator +(ViajeSudamericanos viajeA, Pasajeros pasajero)
        {
            // Verificar si es nulo;
            viajeA = (ViajeSudamericanos)viajeA.AgregarPasajero(viajeA, pasajero);

            return viajeA;
        }
        protected override void calcularCostoPasajes()
        {
            Random numeroAlatorio = new Random();
            base.duracionDelViaje = numeroAlatorio.Next(72, 360);
            base.fechaDeLlegada = base.fechaDeViaje.AddHours(base.duracionDelViaje);
            base.tipoCrucero.HorasDeViaje += base.duracionDelViaje;

            ViajesProgramados viajesProgramados = new ViajesProgramados(base.Destino, base.fechaDeViaje, base.fechaDeLlegada);
            base.tipoCrucero.ListaViajesProgramados.Add(viajesProgramados);


            double costo = 57 * base.duracionDelViaje;
            base.costoViajeTurista = costo;
            base.costoViajePremiun = costo + costo * 0.20;

            int cantidadTurista = 1 + Viajes.cantidad(this, ETipoClase.TURISTA); 
            int cantidadPremiun = 1 + Viajes.cantidad(this, ETipoClase.PREMIUN);
            Viajes.gananciasSudamericanos += (int)base.costoViajeTurista * cantidadTurista;
            Viajes.gananciasSudamericanos += (int)base.costoViajeTurista * cantidadPremiun;

        }
    }
}
