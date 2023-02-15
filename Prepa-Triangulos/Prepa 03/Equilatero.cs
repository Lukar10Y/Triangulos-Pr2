using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class TrianguloEquilatero : Triangulo
    {
        public TrianguloEquilatero(string color, double lado) : base(color, lado, lado, lado)
        {
           
        }

        public override double Altura()
        {
            double _altura = Math.Sqrt(Math.Pow(Lado1, 2) - Math.Pow(Base / 2, 2));

            return _altura;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("\nMi clase es Triangulo Equilatero");
            base.MostrarDatos();
        }
    }
}
