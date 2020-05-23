using System;

namespace Lista3_
{
    class Retangulo : FormaGeometrica
    {
        public override double Area(){
            this.area = Math.Round(this.Base * this.altura, 2);

            return this.area;
        }

        public override double Perimetro(){
            this.perimetro = Math.Round((2 * this.Base) + (2 * this.altura), 2);

            return this.perimetro;
        }
    }
}