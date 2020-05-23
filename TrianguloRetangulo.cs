using System;

namespace Lista3_
{
    class TrianguloRetangulo : FormaGeometrica
    {
        public override double Area(){
            this.area = Math.Round((this.Base * this.altura)/2, 2);
            
            return this.area;
        }

        public override double Perimetro(){
            this.perimetro = Math.Round(this.Base + this.altura + this.hipotenusa, 2);

            return this.perimetro;
        }

    }
}