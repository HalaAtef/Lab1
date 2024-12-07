using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PosNeg
            Console.Write("Plz Enter PosNeg Number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("Number is Positive");
            else if (number < 0)
                Console.WriteLine("Number is Negative");
            else
                Console.WriteLine("Number is Zero");
            #endregion
            ////////////////////////
            #region EvenOdd
            Console.Write("Plz Enter EvenOdd Number: ");
            int number2 = int.Parse(Console.ReadLine());
            if(number2 %2 ==0)
                Console.WriteLine("Number is Even.");
            else
                Console.WriteLine("Number is Odd.");
            #endregion
            ////////////////////////
            #region Rectangle
            Console.Write("Plz Enter Length: ");
            decimal Length = decimal.Parse(Console.ReadLine());
            Console.Write("Plz Enter Width: ");
            decimal Width = decimal.Parse(Console.ReadLine());
            if (Length == Width)
                Console.WriteLine("It is a square.");
            else
                Console.WriteLine("It is a rectangular");
            #endregion
        }
    }
}
