using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Rectangulo: Figura
    {
        private float _base;
        private float _altura;
        public Rectangulo(float base_rectangulo, float altura, string color) : base(color)
        {
            _base = base_rectangulo;
            _altura = altura;

        }

        public override double GetArea()
        {
            return _base * _altura;
        }
        public override double GetPerimetro()
        {
            return (2 * _base) +  (2 * _altura);
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Rectangulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
