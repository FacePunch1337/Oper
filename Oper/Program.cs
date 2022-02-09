using System;

namespace Oper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            var c1 = new DataTypes.Complex
            {
                Re = 1,
                Im = -2
            };

            var c2 = new DataTypes.Complex
            {
                Re = 2,
                Im = -3
            };

            var c3 = new DataTypes.Complex
            {
                Re = 0,
                Im = 1
            };

            var c0 = new DataTypes.Complex
            {
                Re = 0,
                Im = 0
            };
            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
            Console.WriteLine($"{c3} * {c3} = {c3 * c3}");
            try
            {
                Console.WriteLine($"{c1} / {c3} = {c1 / c3}");
                Console.WriteLine($"{c3} / {c3} = {c3 / c3}");
                Console.WriteLine($"{c3} / {c0} = {c3 / c0}");
            }
            catch(Exeptions.ComplexExeption ex)
            {
                Console.WriteLine("Выброшено исключение: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Неизвестное ислючение: " + ex.Message);
            }

        }
    }
}
