using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class Equipaje
    {
        private bool bolsoDeMano;

        private double pesoValija1;
        private double pesoValija2;

        #region constructores
        public Equipaje(bool bolsoDeMano, double pesoValija1, double pesoValija2)
        {
            this.bolsoDeMano = bolsoDeMano;
            this.pesoValija1 = pesoValija1;
            this.pesoValija2 = pesoValija2;
        }
        #endregion

        #region propiedades
        public bool BolsoDeMano { get => this.bolsoDeMano; set => this.bolsoDeMano = value; }
        public double PesoValija1 { get => this.pesoValija1; set => this.pesoValija1 = value; }
        public double PesoValija2 { get => this.pesoValija2; set => this.pesoValija2 = value; }
        #endregion

        #region sobrescritura
        public override string ToString()
        {
            return $"Tiene ? : {this.bolsoDeMano} - Valijas1: {this.pesoValija1} - Peso Valijas2 {this.pesoValija2}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Equipaje)
            {
                return (this == (Equipaje)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
