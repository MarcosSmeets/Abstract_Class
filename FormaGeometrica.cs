using System;

namespace Lista3_
{
    public abstract class FormaGeometrica
    {
        public double Base{get; set;}
        public double altura{get; set;}
        public double hipotenusa{get; set;}
        public double PI{get; set;}
        public double R{get; set;}
        public double area{get; set;}
        public double perimetro{get; set;}

        public abstract double Area();
        public abstract double Perimetro();

        public void mostrarForma(){
            Console.WriteLine("Area: {0} - Perimetro: {1}", Area(), Perimetro());
        }
    }
}