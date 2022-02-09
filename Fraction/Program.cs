using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new DataTypes.Fraction
            {
                Numerator = 1,
                Denumerator = 2
            };

            var f2 = new DataTypes.Fraction
            {
                Numerator = 2,
                Denumerator = 3
            };
            Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
            Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
            Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
            Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
            try
            {
                var f3 = new DataTypes.Fraction { Numerator = 6, Denumerator = 0 };
                Console.WriteLine($"{f1} / {f3} = {f1 / f3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

       
    }
}
