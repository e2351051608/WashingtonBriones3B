using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    class PILA
    {
        public static void Main()
        {
            string palabra;

            Stack LAPila = new Stack();
            LAPila.Push("MUY,");
            LAPila.Push("BUENOS");
            LAPila.Push("DIAS");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)LAPila.Pop();
                Console.WriteLine(palabra);
            }
        }
    }
}
