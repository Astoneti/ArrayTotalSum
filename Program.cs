using System;
using System.Linq;

namespace ArrayTotalSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber = new int[] { 123, 196, 20, 77, 98, 111 };
            int arrSum = 0;
            for (int i = 0; i < arrNumber.Length; i++)
            {
                arrSum += arrNumber[i];    // явно указываем сложение чисел массива
            }
            Console.WriteLine($"Total : {arrSum}");

            //int[] arrNumber = new int[] { 123, 196, 20, 77, 98, 111 };
            //int arrSum = 0;
            //arrSum = arrNumber.Sum();  // вызываем у масива метод Sum(),без исользования цикла For!!!
            //Console.WriteLine($"Total : {arrSum}");
        }
    }
}
