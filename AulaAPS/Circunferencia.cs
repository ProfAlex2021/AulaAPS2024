using System;

namespace AulaAPS
{
    public class Circunferencia : FormaGeometrica
    {
        private int raio;

        public int Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(raio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * (raio * 2) * 3);
        }
    }
}
