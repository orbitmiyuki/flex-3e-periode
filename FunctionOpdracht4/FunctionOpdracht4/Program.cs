using System;
using System.ComponentModel;

namespace FunctionOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();



            int result = program.AddNumbers(2, 6, 18);

            Console.WriteLine("should be 26?");
            Console.WriteLine(result);
        }

        private int AddNumbers(int a, int b, int c)
        
        {

            int totaal = a + b + c;
            return totaal;
        }





        //1) maak hier een function AddNumbers die 3 argumenten heeft
        //2) de function telt de 3 argumenten bij elkaar op en geeft dat als resultaat terug

    }
}