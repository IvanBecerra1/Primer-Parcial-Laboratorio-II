using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class Equipaje
    {
        private bool bolsoDeMano;

        private double pesoValija1;
        private double pesoValija2;

        private double pesoValjasDisponible;

        public Equipaje()
        {
        }

        public Equipaje(bool bolsoDeMano, double pesoValija1, double pesoValija2)
        {
            this.bolsoDeMano = bolsoDeMano;
            this.pesoValija1 = pesoValija1;
            this.pesoValija2 = pesoValija2;
        }
        public override string ToString()
        {
            return $"Tiene ? : {this.bolsoDeMano} - Valijas1: {this.pesoValija1} - Peso Valijas2 {this.pesoValija2}";
        }
        public bool BolsoDeMano { get => bolsoDeMano; set => bolsoDeMano = value; }
        public double PesoValija1 { get => pesoValija1; set => pesoValija1 = value; }
        public double PesoValija2 { get => pesoValija2; set => pesoValija2 = value; }

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
    }
}
