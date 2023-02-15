using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public abstract class Triangulo : Figura
    {
        private double _lado1;
        private double _lado2;
        private double _base;

        public Triangulo(string color) : base(color) { }
        public Triangulo(string color, double lado1, double lado2, double baseTriangulo) : base(color) 
        { 
            _lado1 = lado1;
            _lado2 = lado2;
            _base = baseTriangulo;
        }

        public double Lado1
        {
            get { return _lado1; }
        }

        public double Lado2
        {
            get { return _lado2; }
        }

        public double Base
        {
            get { return _base; }
        }

        public abstract double Altura();

        public override double GetArea()
        {
            return (Base * Altura()) / 2;
        }
      
        public override double GetPerimetro()
        {
            return Lado1 + Lado2 + Base;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"{Tipo()}\nMi color es {GetColor()} y mi Area y Perimetro son:\nArea: {GetArea()}; Perimetro: {GetPerimetro()}");
        }

        public string Tipo()
        {
            if (Lado1 == Lado2 || Lado2 == Base || Base == Lado1)
            {
                if (Lado2 == Base && Lado2 == Lado1) return "Mis caracteristicas son de un Triangulo Equilatero";

                else return "Mis caracteristicas son de un Triangulo Isosceles";
            }
            else return "Mis caracteristicas son de un Triangulo Escaleno";
        }
    }
}
