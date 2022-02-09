using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction.DataTypes
{
    class Fraction
    {
        private int _denominator;
        private int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    public int Numerator { get; set; }
        public int Denumerator
        {
            get; set;
            /*
            get => _denominator;
            
            set
             { 
                 if (value == 0) throw;
                 else _denominator = value; 
             }*/
        }

        public Fraction Reduced
        {
            get
            {
                int g = gcd(this.Numerator, this.Denumerator);
                return new Fraction
                {
                    Numerator = this.Numerator / g,
                    Denumerator = this.Denumerator / g
                };
            }
        }

        public override string ToString()
        {
            return $"({this.Numerator}" + " / " + $"{this.Denumerator})";
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            // Exception
            return new Fraction { Numerator = f1.Numerator + f2.Numerator, Denumerator = f1.Denumerator };
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            // Exception
            return new Fraction { Numerator = f1.Numerator - f2.Numerator, Denumerator = f1.Denumerator };
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * f2.Numerator, Denumerator = f1.Denumerator * f2.Denumerator };
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * f2.Denumerator, Denumerator = f1.Denumerator * f2.Numerator };
        }
    }

}