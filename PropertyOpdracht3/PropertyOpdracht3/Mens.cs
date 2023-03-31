using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (value > leeftijd)
                {
                    leeftijd = value;
                    Console.WriteLine("im 19");
                }
                else
                {
                    Console.WriteLine("and i never learned how to read");
                }
            }
        }

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}