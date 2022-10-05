using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class Salon
    {
        private string tipoSalon;
        public Salon()
        {

        }
        public override bool Equals(object obj)
        {
            return obj is Salon salon &&
                   tipoSalon == salon.tipoSalon;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.tipoSalon;
        }
        public static Salon operator +(Salon salonA, String salon)
        {
            salonA.tipoSalon = salon;
            return salonA;
        }

        public static bool operator ==(Salon salonA, Salon salonB)
        {
            return (salonA.tipoSalon == salonB.tipoSalon);
        }
        public static bool operator !=(Salon salonA, Salon salonB)
        {
            return (salonA.tipoSalon == salonB.tipoSalon);
        }
    }
}
