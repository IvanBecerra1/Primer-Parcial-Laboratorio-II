using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class ViajesProgramados
    {
        private int id;
        private static int idCount;

        private string destino;
        private DateTime fechaSalida;
        private DateTime fechaLLegada;

        #region constructor
        public ViajesProgramados(string destino, DateTime fechaSalida, DateTime fechaLLegada)
        {
            this.id = ViajesProgramados.idCount++;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.fechaLLegada = fechaLLegada;
        }
        #endregion

        #region sobrescritura
        public override string ToString()
        {
            return $"{this.Destino} - {this.fechaSalida.ToString("dd-MM-yyyy")} / {this.fechaLLegada.ToString("dd-MM-yyyy")}";
        }
        public override bool Equals(object obj)
        {
            if (obj is ViajesProgramados)
            {
                return (this == ((ViajesProgramados)obj));
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region propiedades
        public string Destino { get => this.destino; set => this.destino = value; }
        public DateTime FechaLlegada { get => this.fechaLLegada; set => this.fechaLLegada = value; }
        public DateTime FechaSalida { get => this.fechaSalida; set => this.fechaSalida = value; }
        #endregion

        #region sobrecarga de operadores
        public static bool operator ==(ViajesProgramados viajeA, ViajesProgramados viajeB)
        {
            return viajeA.id == viajeB.id;
        }
        public static bool operator !=(ViajesProgramados viajeA, ViajesProgramados viajeB)
        {
            return !(viajeA == viajeB);
        }
        #endregion
    }
}
