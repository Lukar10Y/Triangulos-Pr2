using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class TrianguloEscaleno : Triangulo
    {
        public TrianguloEscaleno(string color, double lado1, double lado2, double baseEscaleno) : base(color, lado1, lado2, baseEscaleno)
        {
       
        }
        public override double Altura()
        {
            double SP = GetPerimetro() / 2; //SemiPerimetro

            double _altura = (2/Base)*Math.Sqrt(SP*((SP-Base)*(SP-Lado1)*(SP-Lado2)));

            return _altura;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("\nMi clase es Triangulo Escaleno");
            base.MostrarDatos();
        }
    }
}
