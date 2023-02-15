using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public abstract class Figura
    {

        private string _color;

        public Figura(string color)
        {
            _color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimetro();
        
        public string GetColor()
        {
            return _color;
        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($" Soy una Figura de Color {_color}");
        }
    }
}
