using System;

namespace Lista3_
{
    class Circulo : FormaGeometrica
    {
        public override double Area(){
            this.area = Math.Round(this.PI * (2*this.R), 2);

            return this.area;
        }

        public override double Perimetro(){
            this.perimetro = Math.Round((2 * this.PI) * this.R, 2);

            return this.perimetro;
        }
    }
}