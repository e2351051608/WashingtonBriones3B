using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class EMPLEADOFIJO : Empleado
    {

        public class EMPLEADOFIJO
        {
            int añosenlaempresa;
            double sueldomensual, sueldofijo, sueldoanual;

           
            public EMPLEADOFIJO(int añosenlaempresa, double sueldomensual)
            {
                int añosenlaempresa;
                double sueldomensual, sueldofijo, sueldoanual;
                sueldomensual = sueldofijo + sueldoanual * añosenlaempresa ;
            }
            public double getsueldomensual()
            {
                return sueldomensual;
            }
            public void setsueldomensual(double sueldomensual)
            {
                this.sueldomensual = sueldomensual;
            }
        }
    }
}