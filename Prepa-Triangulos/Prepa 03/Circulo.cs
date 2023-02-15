using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class Circulo: Figura
    {
        private float _radio;
        private float _diametro;

        public Circulo(float radio, string color) : base(color)
        {
            _radio = radio;
            _diametro = radio * 2;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radio,2);
        }
        public override double GetPerimetro()
        {
            return 2 * Math.PI * _radio;
        }
    }
}
