using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class ViajesProgramados
    {
        private string destino;
        private DateTime fechaSalida;
        private DateTime fechaLLegada;

        public ViajesProgramados(string destino, DateTime fechaSalida, DateTime fechaLLegada)
        {
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.fechaLLegada = fechaLLegada;
        }

        public override string ToString()
        {
            return $"{this.Destino} - {this.fechaSalida.ToString("dd-MM-yyyy")} / {this.fechaLLegada.ToString("dd-MM-yyyy")}";
        }
        public string Destino { get => destino; set => destino = value; }
        public DateTime FechaLlegada { get => fechaLLegada; set => fechaLLegada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
    }
}
