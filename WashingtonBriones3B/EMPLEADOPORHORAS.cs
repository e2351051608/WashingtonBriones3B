using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class EMPLEADOPORHORAS : Empleado
    {
        public class EMPLEADOPORHORAS
        {
            double preciodehoratrabajada, sueldoporhoras;
            int numerodehorastrabajadas;
            public EMPLEADOPORHORAS(double preciohoratrabajada, int numerodehorastrabajadas)
            {
                this.preciodehoratrabajada = preciohoratrabajada;
                this.numerodehorastrabajadas = numerodehorastrabajadas;
                sueldoporhoras = preciohoratrabajada * numerodehorastrabajadas;
            }
            public double getsueldoporhoras()
            {
                return sueldoporhoras;
            }
            public void setsueldoporhoras(double sueldoporhoras)
            {
                this.sueldoporhoras = sueldoporhoras;
            }
        }
    }
   
}