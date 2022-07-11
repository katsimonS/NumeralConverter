using System;
using System.Text;

namespace NumeralConverter
{
    class Program
    {
        static string DecimalToBinary(int decimalNumber)
        {
            var binaryNumber = string.Empty;
            while (decimalNumber > 0)
            {
                binaryNumber = (decimalNumber % 2) + binaryNumber;
                decimalNumber /= 2;
            }

            return binaryNumber;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введите число в десятичной системе: ");
            var decNum = int.Parse(Console.ReadLine());
            var binNum = DecimalToBinary(decNum);
            Console.WriteLine("{0} => {1}", decNum, binNum);
            Console.ReadLine();
        }
    }
}
