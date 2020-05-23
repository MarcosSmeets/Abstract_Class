using System;

namespace Lista3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo cir = new Circulo();
            TrianguloRetangulo tri = new TrianguloRetangulo();
            Retangulo ret = new Retangulo();

            cir.PI = 3.14; cir.R = 5.12;
            Console.WriteLine("Circulo: ");
            cir.mostrarForma();

            tri.altura = 8.7; tri.Base = 6; tri.hipotenusa = 7.36;
            Console.WriteLine("Triangulo Retangulo: ");
            tri.mostrarForma();

            ret.altura = 5; ret.Base = 8;
            Console.WriteLine("Retangulo: ");
            ret.mostrarForma();
        }
    }
}
