using System;

namespace AulaAPS
{
    public class TrianguloReto : Triangulo
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override double CalcularArea()
        {
            return ((_base * altura) / 2);
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa;
            hipotenusa = System.Math.Sqrt(Math.Pow(_base, 2) + Math.Pow(altura, 2));
            return (_base + altura + hipotenusa);
        }
    }
}
