using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    class COLA
    {
        public static void Main()
        {
            string palabra;

            Queue LACola = new Queue();
            LACola.Enqueue("MUY,");
            LACola.Enqueue("BUENOS");
            LACola.Enqueue("DIAS");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)LACola.Dequeue();
                Console.WriteLine(palabra);
            }
        }
    }
}
