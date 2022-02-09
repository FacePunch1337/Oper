using System;
using System.Collections.Generic;
using System.Text;

namespace Oper.DataTypes
{
    class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public double Abs {
            get => Math.Sqrt(this.Re * this.Re + this.Im * this.Im); 
        
        }

        public Complex Conjugate
        {
            get => new Complex { Re = this.Re, Im = -this.Im };
        }

        public override string ToString()
        {
            return $"({this.Re}" + (this.Im < 0 ? "-" : "+") + $"{Math.Abs(this.Im)}i)";

        }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re + c2.Re,
                Im = c1.Im + c2.Im
            };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re - c2.Re,
                Im = c1.Im - c2.Im
            };
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re * c2.Re - c1.Im * c2.Im,
                Im = c1.Im * c2.Re + c1.Re * c2.Im
            };
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
           if(c2.Abs == 0)
            {
                throw new Exeptions.ComplexExeption("Complex division by 0");
            }
            var c = c1 * c2.Conjugate;
            var d = c2.Abs * c2.Abs;
            return new Complex
            {
                Re = c.Re / d,
                Im = c.Im / d
            };
        }

        public static Complex operator +(Complex c1, double r)
        {
            return new Complex { Re = c1.Re + r, Im = c1.Im };
        }

        public static Complex operator *(Complex c1, double r)
        {
            return new Complex { Re = c1.Re * r, Im = c1.Im * r };
        }

        public static Complex operator -(Complex c1, double r)
        {
            return new Complex { Re = c1.Re - r, Im = c1.Im };
        }

        public static Complex operator /(Complex c1, double r)
        {
            if (r == 0) throw new Exeptions.ComplexExeption("Complex division by 0");
            return new Complex { Re = c1.Re / r, Im = c1.Im };
        }

    }
}
