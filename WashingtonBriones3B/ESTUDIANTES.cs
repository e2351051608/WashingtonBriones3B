using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class ESTUDIANTES : PERSONAS
    {
        public class ESTUDIANTES
        {
            string cursodematricula;
            public ESTUDIANTES(string cursodematricula)
            {
                this.cursodematricula = cursodematricula;
            }

            public int getcursodematricula()
            {
                return cursodematricula;
            }
            public void setcursodematricula(string cursodematricula)
            {
                this.númerodedespacho = númerodedespacho;
            }
        }
    }
}