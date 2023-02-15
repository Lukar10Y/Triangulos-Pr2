using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");*/

            TrianguloEquilatero tri = new TrianguloEquilatero("negro",12);

            /*Figura fig = tri;

            fig.MostrarDatos();*/

            tri.MostrarDatos();

            TrianguloIsosceles iso = new TrianguloIsosceles("blanco",8,12);

            iso.MostrarDatos();

            TrianguloEscaleno esca = new TrianguloEscaleno("naranja",8,10,6);

            esca.MostrarDatos();

            Console.ReadLine();
        }
    }
}
